using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

	static public bool UP = false;
	static public bool DOWN = false;
	static public bool LEFT = false;
	static public bool RIGHT = false;

	// Use this for initialization
	void Start ()
	{
        
	}
	
	// Update is called once per frame
    void FixedUpdate ()
	{
        GetPushedKeys();
	}

    void GetPushedKeys() {
        UP = Input.GetKey(Keymap.UP);
        DOWN = Input.GetKey(Keymap.DOWN);
        LEFT = Input.GetKey(Keymap.LEFT);
        RIGHT = Input.GetKey(Keymap.RIGHT);
    }
}
