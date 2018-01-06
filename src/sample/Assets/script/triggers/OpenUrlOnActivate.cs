using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Configuration;

public class OpenUrlOnActivate : MonoBehaviour {

    Rigidbody2D rb;
    BoxCollider2D bc;

    public string url = "";
	// Use this for initialization
	void Start () {
        AddCollision();
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if( Controller.ACTIVATE && url != "" && collision.tag == Tag.Player ) {
            Application.OpenURL(url);
        } 
    }

    void AddCollision() {
        rb = gameObject.AddComponent<Rigidbody2D>();
        bc = gameObject.AddComponent<BoxCollider2D>();

        bc.isTrigger = true;
        rb.bodyType = RigidbodyType2D.Static;
    }
}
