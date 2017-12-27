using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimCursorFollow : MonoBehaviour {

	public GameObject weapon;
	public GameObject Cursor;

	public float angle;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Set cursor position
		SetCursorPosition();

		// Set angle
		SetAngle();
	}

	void SetCursorPosition() {
		// Calc cursor position with mouse position
		Cursor.transform.position = CalcCursorPosition(GetMousePosition());
	}

	void SetAngle() {
        // calc angle from object position and cursor position
        angle = Vector.Rad2Deg(Vector.AngleBetweenTwo2DVectorsInRad(gameObject.transform.position, Cursor.transform.position));

		weapon.transform.rotation = Quaternion.Euler(0f, 0f, angle);
	}

	Vector2 CalcCursorPosition(Vector2 mousePosition) {
        float X = (mousePosition.x);
        float Y = (mousePosition.y);

		return new Vector2(X, Y);
	}

	Vector2 GetMousePosition() {
		// get mouse position on viewport
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
