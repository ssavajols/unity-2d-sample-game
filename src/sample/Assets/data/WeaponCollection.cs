using UnityEngine;
using System.Collections;
using Game.Configuration.Weapon;
namespace Game.Data
{
    public class WeaponCollection
    {
        public enum WeaponTypes
        {
            CQC,
            BULLET,
            ROCKET,
        };

        public enum WeaponList { 
            KNIFE, 
            GUN, 
            SHOTGUN, 
            GATLING, 
            ROCKET_LAUNCHER 
        };

        public static WeaponModel GetWeapon(string name) {
            return (WeaponModel)typeof(WeaponCollection).GetField(name).GetValue(typeof(WeaponCollection));
        }

        public static WeaponModel GetWeapon(WeaponList Weapon) {
            return GetWeapon(Weapon.ToString());
        }

        public static WeaponModel KNIFE = new WeaponModel
        {
            Name = "Knife",
            Weapon = WeaponList.KNIFE,
            Frequency = 1f,
            Accuracy = 0f,
            Damage = 50,
            FirePermanent = false,
            FireCostAmmo = 0,
            Type = WeaponTypes.CQC,
        };

        public static WeaponModel GUN = new WeaponModel
        {
            Name = "Pistol",
            Weapon = WeaponList.GUN,
            Frequency = 0.1f,
            Accuracy = 0.1f,
            Damage = 20,
            FirePermanent = false,
            FireCostAmmo = 1,
            Type = WeaponTypes.BULLET,
        };

        public static WeaponModel SHOTGUN = new WeaponModel
        {
            Name = "Shotgun",
            Weapon = WeaponList.SHOTGUN,
            Frequency = 1.5f,
            Accuracy = 1f,
            Damage = 70,
            FirePermanent = false,
            FireCostAmmo = 1,
            Type = WeaponTypes.BULLET,
        };

        public static WeaponModel GATLING = new WeaponModel
        {
            Name = "Gatling",
            Weapon = WeaponList.GATLING,
            Frequency = 0.05f,
            Accuracy = 0.2f,
            Damage = 10,
            FirePermanent = true,
            FireCostAmmo = 1,
            Type = WeaponTypes.BULLET,
        };

        public static WeaponModel ROCKET_LAUNCHER = new WeaponModel
        {
            Name = "Rocket launcher",
            Weapon = WeaponList.ROCKET_LAUNCHER,
            Frequency = 1.5f,
            Accuracy = 0f,
            Damage = 200,
            FirePermanent = false,
            FireCostAmmo = 1,
            Type = WeaponTypes.ROCKET,
        };

    }
}