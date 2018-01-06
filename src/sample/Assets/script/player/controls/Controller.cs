using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Configuration;

public class Controller : MonoBehaviour
{

	static public bool UP = false;
	static public bool DOWN = false;
	static public bool LEFT = false;
    static public bool RIGHT = false;
    static public bool FIRE = false;
    static public bool FIRE_PERMANENT = false;
    static public bool ALT_FIRE = false;
    static public bool ALT_FIRE_PERMANENT = false;
    static public bool ACTIVATE = false;
    static public bool ACTIVATE_PERMANENT = false;
    static public bool SELECT_1 = false;
    static public bool SELECT_2 = false;
    static public bool SELECT_3 = false;
	static public bool SELECT_4 = false;

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
        FIRE = Input.GetKeyDown(Keymap.FIRE);
        FIRE_PERMANENT = Input.GetKey(Keymap.FIRE);
        ALT_FIRE = Input.GetKeyDown(Keymap.ALT_FIRE);
        ALT_FIRE_PERMANENT = Input.GetKey(Keymap.ALT_FIRE);
        ACTIVATE = Input.GetKeyDown(Keymap.ACTIVATE);
        ACTIVATE_PERMANENT = Input.GetKey(Keymap.ACTIVATE);
        SELECT_1 = Input.GetKeyDown(Keymap.SELECT_1);
        SELECT_2 = Input.GetKeyDown(Keymap.SELECT_2);
        SELECT_3 = Input.GetKeyDown(Keymap.SELECT_3);
        SELECT_4 = Input.GetKeyDown(Keymap.SELECT_4);

    }
}
