using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public GameObject player;
    public float maxDistanceDelta = 0.8f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        MoveCameraToPlayer();
	}

    void MoveCameraToPlayer() {
        if( player == null ) {
            return;
        }

        Vector3 cameraPosition = transform.position;
        Vector3 playerPosition= player.transform.position;

        Vector3 newPosition = Vector3.MoveTowards(
                                        cameraPosition, 
                                        playerPosition, 
                                        maxDistanceDelta);
        
        newPosition.z = transform.position.z; // force to keep the old Z


        transform.position = newPosition;
    }
}
