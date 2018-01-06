
using UnityEngine;
using System.Collections;
using Game.Configuration.Weapon;

namespace Game.Configuration.Ennemy {
    public static class EnnemyCollection
    {
        public static EnnemyModel GUN = new EnnemyModel
        {
            Name = EnnemyNameModel.GUN,
            Health = 20,
            Weapon = WeaponCollection.GUN,
        };
        public static EnnemyModel SHOTGUN = new EnnemyModel
        {
            Name = EnnemyNameModel.SHOTGUN,
            Health = 30,
            Weapon = WeaponCollection.SHOTGUN,
        };
    }

}  
