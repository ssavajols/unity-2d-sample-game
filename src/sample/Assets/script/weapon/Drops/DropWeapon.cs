using UnityEngine;
using System.Collections;
using Game.Weapon;
using Game.Configuration;
using Game.Configuration.Player;
using Game.Configuration.Weapon;

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
            if (W.Name == WeaponNameModel.GUN)
            {
                Player.GunAmmo += Amount;
            }

            if (W.Name == WeaponNameModel.SHOTGUN)
            {
                Player.ShotgunAmmo += Amount;
            }

            if (W.Name == WeaponNameModel.GATLING)
            {
                Player.GatlingAmmo += Amount;
            }

            if (W.Name == WeaponNameModel.ROCKET_LAUNCHER)
            {
                Player.RocketAmmo += Amount;
            }
        }

        protected void AddWeapon() {
            if ( W.Name == WeaponNameModel.GUN ) {
                Player.hasGun = true;
            }

            if ( W.Name == WeaponNameModel.SHOTGUN ) {
                Player.hasShotgun = true;
            }

            if ( W.Name == WeaponNameModel.GATLING ) {
                Player.hasGatling = true;
            }

            if ( W.Name == WeaponNameModel.ROCKET_LAUNCHER ) {
                Player.hasRocketLauncher = true;
            }
                    
        }
    }
}