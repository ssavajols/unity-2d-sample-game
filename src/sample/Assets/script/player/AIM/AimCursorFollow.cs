using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimCursorFollow : MonoBehaviour {

    public GameObject weapon;
	public GameObject FireBulletGenerator;
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
        Vector2 from = gameObject.transform.position;
        Vector2 to = Cursor.transform.position;
        Quaternion angle = Vector.PointVectorTo(from, to);

        weapon.transform.rotation = angle;
		FireBulletGenerator.transform.rotation = angle;
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
