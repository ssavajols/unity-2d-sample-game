using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireKnife : fireBulletSimple {

    float deltaTime = 0f;
    float maxTime = 0.3f;

    // Use this for initialization
    new void Start()
    {
        GetRigidbody();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimer();
        AutoRemove();
    }

    void UpdateTimer() {
        deltaTime += Time.deltaTime;
    }

    void AutoRemove() {
        if( deltaTime > maxTime ) {
            Destroy(gameObject);
        }
    }

    void GetRigidbody()
    {
        base.getRigidbody();
        rb.bodyType = RigidbodyType2D.Static;
    }

}
