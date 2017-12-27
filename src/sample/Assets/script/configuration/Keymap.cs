using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keymap : MonoBehaviour
{

    static public KeyCode UP = KeyCode.Z;
    static public KeyCode DOWN = KeyCode.S;
    static public KeyCode LEFT = KeyCode.Q;
    static public KeyCode RIGHT = KeyCode.D;

	// Use this for initialization
	void Start ()
	{
        setInitialKeys();
    }
    
	// Update is called once per frame
	void Update ()
	{
		
	}

    void setInitialKeys() {
        updateKey("UP", KeyCode.UpArrow);
        updateKey("DOWN", KeyCode.DownArrow);
        updateKey("LEFT", KeyCode.LeftArrow);
        updateKey("RIGHT", KeyCode.RightArrow);
    }

    void updateKey(string keyName, KeyCode keyCode) {
        var prop = this.GetType().GetProperty(keyName);

        if( prop != null ) {
            prop.SetValue(this, keyCode, null);    
        }
    }
}
