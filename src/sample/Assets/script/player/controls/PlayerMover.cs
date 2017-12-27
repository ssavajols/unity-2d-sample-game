using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{

	public float speed = 0.01f;
	// Use this for initialization
	void Start ()
	{
        AddControllerComponent();
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

    void FixedUpdate()
    {
        CalcMovement();
    }

    void AddControllerComponent() {
        gameObject.AddComponent<Controller>();
    }

    void CalcMovement() {
        Vector3 newPosition = new Vector3(0, 0, 0);

        if (Controller.UP)
        {
            newPosition.y += 1 * speed;
        }
        if (Controller.DOWN)
        {
            newPosition.y -= 1 * speed;
        }
        if (Controller.LEFT)
        {
            newPosition.x -= 1 * speed;
        }
        if (Controller.RIGHT)
        {
            newPosition.x += 1 * speed;
        }

        ApplyMove(newPosition);
    }

    void ApplyMove(Vector3 newPosition) {
        transform.position = transform.position + newPosition;
    }
}
