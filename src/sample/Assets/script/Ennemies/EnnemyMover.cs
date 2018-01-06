using UnityEngine;
using System.Collections;

public class EnnemyMover : MonoBehaviour
{

    public Vector2 Target;

    Rigidbody2D rb;
    BoxCollider2D bc;

    private void OnDrawGizmos()
    {
        Vector2 v = (Vector2)transform.position + Target;
        Gizmos.color = new Color(0, 255, 0, 0.5f);
        Gizmos.DrawCube(v, new Vector3(0.2f, 0.2f, 0.2f));
    }

	// Use this for initialization
	void Start()
	{
        AddCollider();
	}

	// Update is called once per frame
	void Update()
	{
        Move();
    }

    void AddCollider()
    {
        bc = gameObject.GetComponent<BoxCollider2D>();
        rb = gameObject.AddComponent<Rigidbody2D>();

        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.gravityScale = 0;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    void Move()
    {
        ApplyMove();
    }

    void ApplyMove()
    {
        if( Target != null ) {
            rb.velocity = Target;    
        }
    }
}
