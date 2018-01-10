using UnityEngine;
using System.Collections;
using Game.Data;

namespace Game.Configuration.Weapon {
    [System.Serializable]
    public class WeaponModel
    {
        public string Name = "weapon";
        public WeaponCollection.WeaponList Weapon;
        public float Frequency = 1f;
        public float Accuracy = 0f;
        public bool FirePermanent = false;
        public int FireCostAmmo = 1;
        public int Damage = 0;
        public WeaponCollection.WeaponTypes Type = WeaponCollection.WeaponTypes.BULLET;

        public void FireCost() {
            if( Weapon == WeaponCollection.WeaponList.GUN ) {
                Player.Player.GunAmmo -= FireCostAmmo;
            }
            if (Weapon == WeaponCollection.WeaponList.SHOTGUN)
            {
                Player.Player.ShotgunAmmo -= FireCostAmmo;
            }
            if( Weapon == WeaponCollection.WeaponList.GATLING ) {
                Player.Player.GatlingAmmo -= FireCostAmmo;
            }
            if( Weapon == WeaponCollection.WeaponList.ROCKET_LAUNCHER ) {
                Player.Player.RocketAmmo -= FireCostAmmo;
            }
        }

        public bool CanFire() {
            if (Weapon == WeaponCollection.WeaponList.GUN)
            {
                return Player.Player.GunAmmo > 0;
            }
            if (Weapon == WeaponCollection.WeaponList.SHOTGUN)
            {
                return Player.Player.ShotgunAmmo > 0;
            }
            if (Weapon == WeaponCollection.WeaponList.GATLING)
            {
                return Player.Player.GatlingAmmo > 0;
            }
            if (Weapon == WeaponCollection.WeaponList.ROCKET_LAUNCHER)
            {
                return Player.Player.RocketAmmo > 0;
            }

            return false;
        }
    }
}
