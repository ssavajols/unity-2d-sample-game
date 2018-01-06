using UnityEngine;
using System.Collections;
using Game.Configuration.Player;
using Game.Configuration.Ennemy;
using Game.Configuration.Weapon;
using Game.Configuration;

public class EnnemyActions : MonoBehaviour
{

    public GameObject fireBulletGenerator;
	public bool CanTriggerFire;
    public int Health;
    public EnnemyModel Ennemy;

    RaycastHit2D[] lineCastFree;
    Vector2 lineCastTo;
    Vector2 lineCastFrom;
    FireBulletGenerator fireBullet;

    Cooldown coolDown = new Cooldown();

    void Start() 
    {
        GetFireBulletScript();
        SetHealth();
    }

    void Update()
    {
        coolDown.Update(Ennemy.Weapon.Frequency);

        if (PlayerConfiguration.CurrentPlayer.gameObject == null) { return; }
        LineCastDetection();
        DetectTriggerFire();
        Die();
    }

    void SetHealth() {
        Health = Ennemy.Health;
    }

    void GetFireBulletScript()
    {
        fireBullet = fireBulletGenerator.GetComponent<FireBulletGenerator>();
    }

    void OnDrawGizmos()
    {
        if (PlayerConfiguration.CurrentPlayer.gameObject == null) { return; }

        Color red = new Color(255, 0, 0, 0.8f);
        Color green = new Color(0, 255, 0, 0.8f);
        Vector2 from = lineCastFrom;
        Vector2 to = PlayerConfiguration.CurrentPlayer.gameObject.transform.position;

        Debug.DrawLine(from, to, CanTriggerFire ? green : red);
    }

    void DetectTriggerFire()
    {

        bool lessThan3hits = lineCastFree.Length < 3;
        bool isPlayer = false;
        CanTriggerFire = false;

        for (int i = 0; i < lineCastFree.Length; i++) {

            isPlayer = lineCastFree[i].transform.gameObject.tag == Tag.Player;

            if (isPlayer && lessThan3hits && coolDown.isTrigerrable)
            {
                CanTriggerFire = true;
            }
        }
    }

    public void Fire()
    {
        if( coolDown.isTrigerrable ) {
			PointFireBulletToPlayer();
            fireBullet.Fire(Ennemy.Weapon);
        }
    }

    void PointFireBulletToPlayer() 
    {

        if (PlayerConfiguration.CurrentPlayer.gameObject == null) { return; }

        if( fireBulletGenerator == null ) {
            return;
        }
        Vector3 from = transform.position;
        Vector3 to = PlayerConfiguration.CurrentPlayer.transform.position;
        Vector.PointVectorTo(from, to, fireBulletGenerator.transform);
    }

    void LineCastDetection() 
    {

        lineCastFrom = transform.position;
        lineCastTo = PlayerConfiguration.CurrentPlayer.transform.position;
        lineCastFree = Physics2D.LinecastAll(lineCastFrom, lineCastTo, Layer.GetIndexByNameLayer(Layer.CHARACTERS));
    }

    void Die() {
        if ( Health < 1 ) {
            Destroy(gameObject);
        }
    }

    public void ApplyDamage(WeaponModel weapon)
    {
		Health -= weapon.Damage;
        GuiDamageCounter.SetDamageCounter(Ennemy.Name, Health, Ennemy.Health);
    }


}
