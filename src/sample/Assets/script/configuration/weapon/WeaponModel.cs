using UnityEngine;
using System.Collections;

namespace Game.Configuration.Weapon {
    public class WeaponModel
    {
        public string Name = "weapon";
        public float Frequency = 1f;
        public float Accuracy = 0f;
        public bool FirePermanent = false;
        public int FireCostAmmo = 1;
        public int Damage = 0;
        public string Type = WeaponTypes.BULLET;

        public void FireCost() {
            if( Name == WeaponNameModel.GUN ) {
                Player.Player.GunAmmo -= FireCostAmmo;
            }
            if (Name == WeaponNameModel.SHOTGUN)
            {
                Player.Player.ShotgunAmmo -= FireCostAmmo;
            }
            if( Name == WeaponNameModel.GATLING ) {
                Player.Player.GatlingAmmo -= FireCostAmmo;
            }
            if( Name == WeaponNameModel.ROCKET_LAUNCHER ) {
                Player.Player.RocketAmmo -= FireCostAmmo;
            }
        }

        public bool CanFire() {
            if (Name == WeaponNameModel.GUN)
            {
                return Player.Player.GunAmmo > 0;
            }
            if (Name == WeaponNameModel.SHOTGUN)
            {
                return Player.Player.ShotgunAmmo > 0;
            }
            if (Name == WeaponNameModel.GATLING)
            {
                return Player.Player.GatlingAmmo > 0;
            }
            if (Name == WeaponNameModel.ROCKET_LAUNCHER)
            {
                return Player.Player.RocketAmmo > 0;
            }

            return false;
        }
    }
}
