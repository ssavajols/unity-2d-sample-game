
using UnityEngine;
using System.Collections;
using Game.Configuration.Ennemy;

namespace Game.Data {
    public static class EnnemyCollection
    {
        public enum EnnemyList { 
            GUN, 
            SHOTGUN,
        };

        public static EnnemyModel GetEnnemyByName(string name)
        {
            return (EnnemyModel)typeof(EnnemyCollection).GetField(name).GetValue(typeof(EnnemyCollection));
        }

        public static EnnemyModel GetEnnemyByName(EnnemyList name)
        {
            return GetEnnemyByName(name.ToString());
        }

        public static EnnemyModel GUN = new EnnemyModel
        {
            Name = EnnemyList.GUN.ToString(),
            Health = 20,
            Weapon = WeaponCollection.GUN,
        };

        public static EnnemyModel SHOTGUN = new EnnemyModel
        {
            Name = EnnemyList.SHOTGUN.ToString(),
            Health = 30,
            Weapon = WeaponCollection.SHOTGUN,
        };
    }

}  
