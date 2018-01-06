using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyAI : MonoBehaviour {

    public float speed = 0.5f;

    EnnemyActions EnnemyActions;
    EnnemyMover EnnemyMover;

    float deltaTime = 0f;
    float maxTime = 1f;

    void Start() {
        GetEnnemyMover();
        GetEnnemyActions();
    }

    void Update()
    {
        Move();
    }

    void Move() {
        if (deltaTime > maxTime) {
            deltaTime = 0;
            DoAction();
            UpdateTarget();
        }
        deltaTime += Time.deltaTime;
    }

    void DoAction() {
        float randomeValueFloat = Random.Range(0f, 1f);
        int randomValue = Mathf.RoundToInt(randomeValueFloat);
        if ( randomValue == 1 && EnnemyActions.CanTriggerFire ) {
			Fire();
        } else {
            UpdateTarget();
        }
    }

    void Fire() {
        EnnemyActions.Fire();
    }

    void UpdateTarget(GameObject target = null)
    {
        float X = (Random.Range(0f, 1f) - 0.5f) * 2f;
        float Y = (Random.Range(0f, 1f) - 0.5f) * 2f;
        EnnemyMover.Target = new Vector2(X, Y).normalized * speed;
    }

    void GetEnnemyMover() {
        EnnemyMover = gameObject.GetComponent<EnnemyMover>();
    }
    void GetEnnemyActions() {
        EnnemyActions = gameObject.GetComponent<EnnemyActions>();
    }
}
