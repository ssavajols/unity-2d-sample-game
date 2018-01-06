using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Configuration.Player {
    public static class Player
    {
        public static int Health = 100;
        public static int Armor = 0;

        public static int GunAmmo = 0;
        public static int ShotgunAmmo = 0;
        public static int GatlingAmmo = 0;
        public static int RocketAmmo = 0;

        public static bool hasGun = false;
        public static bool hasShotgun = false;
        public static bool hasGatling = false;
        public static bool hasRocketLauncher = false;
    }
}
