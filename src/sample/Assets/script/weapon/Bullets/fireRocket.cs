using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireRocket : fireBulletSimple {

   new protected void Start()
    {
        speed = 5f;
        base.Start();
    }
}
