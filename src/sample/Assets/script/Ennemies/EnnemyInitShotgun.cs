using UnityEngine;
using System.Collections;
using Game.Data;

public class EnnemyInitShotgun : EnnemyInit
{
    new void Start() {
        Ennemy = EnnemyCollection.SHOTGUN;
        base.Start();
    } 
}
