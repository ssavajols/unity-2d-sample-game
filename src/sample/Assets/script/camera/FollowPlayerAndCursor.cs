using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerAndCursor : MonoBehaviour {

    public GameObject player;
    public GameObject cursor;
    public float maxDistanceDelta = 0.8f;

    	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        MoveCameraToPlayer();
    }

    void MoveCameraToPlayer()
    {
        if (player == null)
        {
            return;
        }

        if (cursor == null ) {
            return;
        }

        Vector3 cameraPosition= transform.position;
        Vector3 playerPositionNormalized  = Vector.GetNormalizedPointBetweenTwo3DVectors(player.transform.position, cursor.transform.position, 1);

        Vector3 newPosition = Vector3.MoveTowards(
                                        cameraPosition, 
                                        playerPositionNormalized, 
                                        maxDistanceDelta);

        newPosition.z = transform.position.z; // force to keep the old Z

        transform.position = newPosition;
    }

}
