using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAsync : MonoBehaviour {
    public enum Levels {
        HUB,
        LEVEL_1_0_0,
        LEVEL_1_0_1,
        LEVEL_1_0_2,
        LEVEL_1_0_3,
        LEVEL_1_1_0,
        LEVEL_2_0_0
    }
    public Levels Level;

    List<string> LoadedLevels = new List<string>();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if( collision.gameObject.tag == Game.Configuration.Tag.Player ) {
            StartCoroutine(Load(SceneManager.GetActiveScene().name, Level.ToString()));    
        }
    }

    void Update() {
    } 

    IEnumerator Load(string oldScene, string newScene) {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(newScene, LoadSceneMode.Additive);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        Debug.Log("Loading complete");
        if( oldScene != Levels.HUB.ToString() ){
            SceneManager.UnloadSceneAsync(oldScene);    
        }
    }
}
