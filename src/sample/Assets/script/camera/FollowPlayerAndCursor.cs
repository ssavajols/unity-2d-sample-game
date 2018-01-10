using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Configuration.Player;

public class FollowPlayerAndCursor : MonoBehaviour {

    GameObject target;
    public GameObject cursor;
    public float maxDistanceDelta = 0.8f;

    // Update is called once per frame
    void Update()
    {
        if ( target == null ) {
            SetTarget(PlayerConfiguration.CurrentPlayer);    
        }
        MoveCameraToPlayer();
    }

    public void SetTarget(GameObject t) {
        target = t;
    }

    void MoveCameraToPlayer()
    {
        if (target == null)
        {
            return;
        }

        if (cursor == null ) {
            return;
        }

        Vector3 cameraPosition = transform.position;
        Vector3 playerPositionNormalized  = Vector.GetNormalizedPointBetweenTwo3DVectors(target.transform.position, cursor.transform.position, 1);

        Vector3 newPosition = Vector3.MoveTowards(
                                        cameraPosition, 
                                        playerPositionNormalized, 
                                        maxDistanceDelta);

        newPosition.z = transform.position.z; // force to keep the old Z

        transform.position = newPosition;
    }

}
