using UnityEngine;
using System.Collections;

namespace Game.Configuration.Weapon
{
    public class WeaponCollection
    {
        public enum WeaponList { KNIFE, GUN, SHOTGUN, GATLING, ROCKET_LAUNCHER };
        public static WeaponList List;

        public static WeaponModel GetWeapon(WeaponList Weapon) {
            switch( Weapon ) {
                case WeaponList.KNIFE:
                    return KNIFE;
                case WeaponList.GUN:
                    return GUN;
                case WeaponList.SHOTGUN:
                    return SHOTGUN;
                case WeaponList.GATLING:
                    return GATLING;
                case WeaponList.ROCKET_LAUNCHER:
                    return ROCKET_LAUNCHER;
            }

            return null;
        }

        public static WeaponModel KNIFE = new WeaponModel
        {
            Name = WeaponNameModel.KNIFE,
            Frequency = 1f,
            Accuracy = 0f,
            Damage = 50,
            FirePermanent = false,
            FireCostAmmo = 0,
            Type = WeaponTypes.CQC,
        };

        public static WeaponModel GUN = new WeaponModel
        {
            Name = WeaponNameModel.GUN,
            Frequency = 0.1f,
            Accuracy = 0.1f,
            Damage = 20,
            FirePermanent = false,
            FireCostAmmo = 1,
            Type = WeaponTypes.BULLET,
        };

        public static WeaponModel SHOTGUN = new WeaponModel
        {
            Name = WeaponNameModel.SHOTGUN,
            Frequency = 1.5f,
            Accuracy = 1f,
            Damage = 70,
            FirePermanent = false,
            FireCostAmmo = 1,
            Type = WeaponTypes.BULLET,
        };

        public static WeaponModel GATLING = new WeaponModel
        {
            Name = WeaponNameModel.GATLING,
            Frequency = 0.05f,
            Accuracy = 0.2f,
            Damage = 10,
            FirePermanent = true,
            FireCostAmmo = 1,
            Type = WeaponTypes.BULLET,
        };

        public static WeaponModel ROCKET_LAUNCHER = new WeaponModel
        {
            Name = WeaponNameModel.ROCKET_LAUNCHER,
            Frequency = 1.5f,
            Accuracy = 0f,
            Damage = 200,
            FirePermanent = false,
            FireCostAmmo = 1,
            Type = WeaponTypes.ROCKET,
        };

    }
}