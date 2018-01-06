using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Configuration.Player;
using Game.Configuration.Weapon;

public class FireBulletGenerator : MonoBehaviour {

    public GameObject Bullet;
    public GameObject Rocket;
    public GameObject Knife;
    public GameObject BulletContainer;

	void Start () {
        GetBulletContainer();
	}
	
    void GetBulletContainer() {
        if( BulletContainer == null ) {
            BulletContainer = transform.parent.gameObject;
        }
    }

    private void FireCQC(WeaponModel weapon) {
        if( Knife ==  null) { return; }

        CreateBullet(Knife, weapon);
    }

    private void FireRocket(WeaponModel weapon)
    {
        if (Rocket== null) { return; }

        CreateBullet(Rocket, weapon);

    }

    private void FireBullet(WeaponModel weapon) {
        if( Bullet == null ) { return; }

        CreateBullet(Bullet, weapon);
    }

    private void CreateBullet(GameObject bullet, WeaponModel weapon) {
        Quaternion rotation = transform.rotation;
        GameObject fireBullet = (GameObject)Instantiate(bullet, transform.position, Quaternion.identity, BulletContainer.transform);

        rotation.z += Random.Range(-weapon.Accuracy/ 2, weapon.Accuracy/ 2);

        fireBullet.tag = tag;
        fireBullet.transform.rotation = rotation;

        if (weapon.Type == WeaponTypes.CQC)
        {
            fireBullet.GetComponent<global::fireKnife>().Weapon = weapon;
        }

        if (weapon.Type == WeaponTypes.BULLET)
        {
            fireBullet.GetComponent<global::fireBulletSimple>().Weapon = weapon;
        }

        if (weapon.Type == WeaponTypes.ROCKET)
        {
            fireBullet.GetComponent<global::fireRocket>().Weapon = weapon;
        }

    }

    public void Fire(WeaponModel weapon) {
        if ( weapon.Type == WeaponTypes.CQC ) {
            FireCQC(weapon);
        }

        if ( weapon.Type == WeaponTypes.BULLET ) {
            FireBullet(weapon);
        }

        if ( weapon.Type == WeaponTypes.ROCKET ) {
            FireRocket(weapon);
        }
    }
}
