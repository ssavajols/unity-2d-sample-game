using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using Game.Data;

namespace Game.Configuration.Scene {
    public class SceneLoader : MonoBehaviour
    {
        static SceneLoader Instance;

        void Start() {
            SetInstance();
            UnloadAllScene();
        }

        void SetInstance() {
            Instance = this;
        }

        public static SceneLoader GetInstance() {
            return Instance;
        }

        void UnloadAllScene() {
            for (int index = 0; index < SceneManager.sceneCount; index ++) {
                if( SceneManager.GetSceneAt(index).name != SceneCollection.HUB.Scene ) {
                    Unload(SceneManager.GetSceneAt(index).name);
                }
            }
        }

        bool IsSceneLoaded(string sceneName) {
            bool sceneLoaded = false;
            for (int index = 0; index < SceneManager.sceneCount; index++) {
                if( SceneManager.GetSceneAt(index).name == sceneName) {
                    sceneLoaded = true;
                }    
            }
            return sceneLoaded;
        }

        void SetActiveScene(SceneModel newScene) {
            SceneManager.SetActiveScene(SceneManager.GetSceneByName(newScene.Scene));
        }

        IEnumerator LoadRouting(SceneModel newScene) {
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(newScene.Scene, LoadSceneMode.Additive);

            while (!asyncLoad.isDone) 
                yield return null;
        }

        public void Load(string sceneName)
        {
            SceneModel scene = SceneCollection.GetSceneByName(sceneName);

            if (scene == null || IsSceneLoaded(scene.Scene))
            {
                return;
            }

            StartCoroutine(LoadRouting(scene));
        }

        public void Unload(string sceneName)
        {
            if( IsSceneLoaded(sceneName) ) {
                SceneManager.UnloadSceneAsync(sceneName);    
            }
        }

    }
}
