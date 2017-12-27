using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    static public float AngleBetweenTwo2DVectorsInRad(Vector2 from, Vector2 to)
    {
        return Mathf.Atan2(to.y - from.y, to.x - from.x);
    }

    static public float Rad2Deg(float rad)
    {
        return rad * 180 / Mathf.PI;
    }

    static public Vector3 GetPointBetweenTwo3DVectors(Vector3 P1, Vector3 P2) {
        return P2 - P1;
    }

    static public Vector3 GetNormalizedPointBetweenTwo3DVectors(Vector3 P1, Vector3 P2, float factor = 1)
    {
        return factor * Vector3.Normalize(P2 - P1) + P1;
    }
}
