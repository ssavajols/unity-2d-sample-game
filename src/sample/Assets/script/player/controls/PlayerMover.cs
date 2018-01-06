using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Configuration.Player;

public class PlayerMover : MonoBehaviour
{

	public float speed = 0.01f;
    private Animator animator;

    Rigidbody2D rb;
    BoxCollider2D bc;

	// Use this for initialization
	void Start ()
	{
        AddCollider();
        AddControllerComponent();
        GetAnimatorComponent();
	}
	
	// Update is called once per frame
	void Update ()
	{
	}

    void FixedUpdate()
    {
        CalcMovement();
    }

    void AddCollider() {
        bc = gameObject.GetComponent<BoxCollider2D>();
        rb = gameObject.AddComponent<Rigidbody2D>();

        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.gravityScale = 0;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void AddControllerComponent() {
        PlayerConfiguration.CurrentPlayer.AddComponent<Controller>();
    }

    void GetAnimatorComponent()
    {
        animator = PlayerConfiguration.CurrentPlayer.GetComponent<Animator>();
    }

    void CalcMovement() {
        bool playWalkAnimation = false;
        Vector3 newPosition = new Vector3(0, 0, 0);

        rb.velocity = Vector2.zero;

        if (Controller.UP)
        {
            newPosition.y += 1 * speed;
            playWalkAnimation = true;
        }
        if (Controller.DOWN)
        {
            newPosition.y -= 1 * speed;
            playWalkAnimation = true;
        }
        if (Controller.LEFT)
        {
            newPosition.x -= 1 * speed;
            playWalkAnimation = true;
        }
        if (Controller.RIGHT)
        {
            newPosition.x += 1 * speed;
            playWalkAnimation = true;
        }

        ApplyMove(newPosition);
        PlayWalkAnimation(playWalkAnimation);
    }


    void PlayWalkAnimation(bool play) {
        if( play ) {
            animator.Play("DOOM GUY WALK");
        } else {
            animator.Play("DOOM GUY - IDLE");
        }
    }

    void ApplyMove(Vector3 newPosition) {
        if (PlayerConfiguration.CurrentPlayer != null) {
            PlayerConfiguration.CurrentPlayer.transform.position = PlayerConfiguration.CurrentPlayer.transform.position + newPosition;    
        }
    }
}
