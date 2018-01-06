using UnityEngine;
using System.Collections;
using Game.Configuration.Ennemy;

public class EnnemyInitGun : EnnemyInit
{
    new void Start() {
        Ennemy = EnnemyCollection.GUN;
        base.Start();
    } 
}
