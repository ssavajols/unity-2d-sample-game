using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Configuration.Player;
using Game.Configuration.Weapon;
using Game.Data;

public class PlayerActions : MonoBehaviour {

    public GameObject fireBulletGenerator;
    private Cooldown coolDown = new Cooldown();

    FireBulletGenerator fireBullet;


	void Start () {
        GetFireBulletScript();
	}

    void Update () {
        setWeapon();
        coolDown.Update(PlayerConfiguration.ActiveWeapon.Frequency);
        Fire(PlayerConfiguration.ActiveWeapon);
        FireKnife(WeaponCollection.KNIFE);
        Die();
    }

    void GetFireBulletScript()
    {
        fireBullet = fireBulletGenerator.GetComponent<FireBulletGenerator>();
    }

    void setWeapon() {
        if( Controller.SELECT_1 ) {
            PlayerConfiguration.SetWeapon(1);    
        }
        if( Controller.SELECT_2 ) {
            PlayerConfiguration.SetWeapon(2);    
        }
        if( Controller.SELECT_3 ) {
            PlayerConfiguration.SetWeapon(3);    
        }
        if( Controller.SELECT_4 ) {
            PlayerConfiguration.SetWeapon(4);    
        }
    }
    
    void Fire(WeaponModel weapon) {
        bool fireButtonPush = (Controller.FIRE && !weapon.FirePermanent) || (Controller.FIRE_PERMANENT && weapon.FirePermanent);
        bool hasAmmo = weapon.CanFire();
        if ( fireButtonPush && coolDown.isTrigerrable && hasAmmo ) {
            fireBullet.Fire(weapon);
            weapon.FireCost();
            coolDown.Triggered();
        }
    }

    void FireKnife(WeaponModel weapon) {
        if( !Controller.FIRE && Controller.ALT_FIRE ) {
            fireBullet.Fire(weapon);
        }
    }

    void Die() {
        if (Player.Health < 1 && gameObject) {
            gameObject.SetActive(false);
        }
    }

    public void ApplyDamage(WeaponModel weapon) {
        float damage = weapon.Damage / 2;
        float armorPercent = Player.Armor * 0.5f / 100;
        int reduceDamaged = Mathf.RoundToInt( damage - ((float)damage *  armorPercent));
        Player.Health -= Mathf.Min(100, Mathf.Max(0, reduceDamaged));
        Player.Armor = Mathf.Min(100, Mathf.Max(0, Player.Armor - reduceDamaged));
    }

}
