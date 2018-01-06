using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooldown {

    float deltaTime = 0;
    public float coolDown = 1f;
    public bool isTrigerrable = false;

	// Update is called once per frame
	public void Update (float newCoolDown = 0f) {
        if( newCoolDown > 0f ) {
            coolDown = newCoolDown;
        }
        CheckCoolDown();
    }

    public void Triggered() {
        isTrigerrable = false;
    }

    void CheckCoolDown()
    {
        if (isTrigerrable) return;

        if (deltaTime > coolDown)
        {
            SetTriggerable();
            return;
        }

        IncrementDeltaTime();

    }

    void SetTriggerable() {
        deltaTime = 0;
        isTrigerrable = true;
    }

    void IncrementDeltaTime() {
        deltaTime += Time.deltaTime;
    }
}
