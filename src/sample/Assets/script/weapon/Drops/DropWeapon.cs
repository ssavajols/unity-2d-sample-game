using UnityEngine;
using System.Collections;
using Game.Configuration;
using Game.Configuration.Player;
using Game.Configuration.Weapon;
using Game.Data;
namespace Game.Weapon
{
    public class DropWeapon : MonoBehaviour
    {
        public int Amount = 1;
        public bool GiveWeapon = true;
        public WeaponCollection.WeaponList Weapon;
        protected WeaponModel W;

        protected void Start()
        {
            SetWeapon();
            AddColliderComponents();
        }

        void SetWeapon() {
            W = WeaponCollection.GetWeapon(Weapon);
        }

        protected void AddColliderComponents()
        {
            Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D>();
            BoxCollider2D bc = gameObject.AddComponent<BoxCollider2D>();

            rb.bodyType = RigidbodyType2D.Static;
            bc.isTrigger = true;

        }

        protected void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == Tag.Player)
            {
                if ( GiveWeapon ) {
                    AddWeapon();    
                }

                AddAmmo();
                Destroy(gameObject);
            }
        }

        protected void AddAmmo() {
            if (W.Name == WeaponCollection.GUN.Name)
            {
                Player.GunAmmo += Amount;
            }

            if (W.Name == WeaponCollection.SHOTGUN.Name)
            {
                Player.ShotgunAmmo += Amount;
            }

            if (W.Name == WeaponCollection.GATLING.Name)
            {
                Player.GatlingAmmo += Amount;
            }

            if (W.Name == WeaponCollection.ROCKET_LAUNCHER.Name)
            {
                Player.RocketAmmo += Amount;
            }
        }

        protected void AddWeapon() {
            if ( W.Name == WeaponCollection.GUN.Name ) {
                Player.hasGun = true;
            }

            if ( W.Name == WeaponCollection.SHOTGUN.Name ) {
                Player.hasShotgun = true;
            }

            if ( W.Name == WeaponCollection.GATLING.Name ) {
                Player.hasGatling = true;
            }

            if ( W.Name == WeaponCollection.ROCKET_LAUNCHER.Name ) {
                Player.hasRocketLauncher = true;
            }
                    
        }
    }
}