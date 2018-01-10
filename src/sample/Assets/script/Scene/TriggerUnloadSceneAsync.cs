using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Configuration.Scene;
using Game.Configuration;
using Game.Data;

public class TriggerUnloadSceneAsync : MonoBehaviour {
    
    public List<SceneCollection.SceneList> Levels = new List<SceneCollection.SceneList>();

    // Draw trigger zone
    void OnDrawGizmos()
    {
        BoxCollider2D bc = GetComponent<BoxCollider2D>();
        Gizmos.color = bc.isTrigger ? ColorList.Red : ColorList.Yellow;
        Gizmos.DrawCube(transform.position, bc.size);
    }

    // Trigger enter
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == Tag.Player)
        {
            Levels.ForEach((level) => {
                SceneLoader.GetInstance().Unload(level.ToString());
            });
        }
    }
}
