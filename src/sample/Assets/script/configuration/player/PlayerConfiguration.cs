using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Configuration.Weapon;
using Game.Data;

namespace Game.Configuration.Player {
    public class PlayerConfiguration {

        public static GameObject CurrentPlayer;
        public static WeaponModel ActiveWeapon = new WeaponModel();

        public static void SetWeapon(int weaponIndex)
        {
            switch (weaponIndex)
            {
                case 1:
                    if (canEquip(WeaponCollection.GUN))
                    {
                        ActiveWeapon = WeaponCollection.GUN;
                    }
                    break;
                case 2:
                    if (canEquip(WeaponCollection.SHOTGUN))
                    {
                        ActiveWeapon = WeaponCollection.SHOTGUN;
                    }
                    break;
                case 3:
                    if (canEquip(WeaponCollection.GATLING))
                    {
                        ActiveWeapon = WeaponCollection.GATLING;
                    }
                    break;
                case 4:
                    if (canEquip(WeaponCollection.ROCKET_LAUNCHER) )
                    {
                        ActiveWeapon = WeaponCollection.ROCKET_LAUNCHER;
                    }
                    break;
            }
        }

        private static bool canEquip(WeaponModel Weapon) {
            return hasWeapon(Weapon) && ActiveWeapon != Weapon;
        }

        private static bool hasWeapon(WeaponModel Weapon) {
            bool hasGun = Weapon.Weapon == WeaponCollection.WeaponList.GUN && Player.hasGun;
            bool hasShotgun = Weapon.Weapon == WeaponCollection.WeaponList.SHOTGUN && Player.hasShotgun;
            bool hasGatling = Weapon.Weapon == WeaponCollection.WeaponList.GATLING && Player.hasGatling;
            bool hasRocketLauncher = Weapon.Weapon == WeaponCollection.WeaponList.ROCKET_LAUNCHER && Player.hasRocketLauncher;

            return hasGun || hasShotgun || hasGatling || hasRocketLauncher;
        }
    }
}  
    