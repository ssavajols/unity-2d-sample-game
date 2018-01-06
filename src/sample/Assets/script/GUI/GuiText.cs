using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiText : MonoBehaviour {

    protected UnityEngine.UI.Text text;
	// Use this for initialization
	protected void Start () {
        GetText();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    protected void GetText() {
        text = gameObject.GetComponentInChildren<UnityEngine.UI.Text>();
    }
}
