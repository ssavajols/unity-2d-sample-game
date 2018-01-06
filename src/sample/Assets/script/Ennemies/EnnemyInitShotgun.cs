using UnityEngine;
using System.Collections;
using Game.Configuration.Ennemy;

public class EnnemyInitShotgun : EnnemyInit
{
    new void Start() {
        Ennemy = EnnemyCollection.SHOTGUN;
        base.Start();
    } 
}
