using UnityEngine;
using System.Collections;
using Game.Data;

public class EnnemyInitGun : EnnemyInit
{
    new void Start() {
        Ennemy = EnnemyCollection.GUN;
        base.Start();
    } 
}
