using System.Collections;
using System.Reflection;
using System.Collections.Generic;
using UnityEngine;
using Game.Configuration.Scene;

namespace Game.Data
{
    public static class SceneCollection
    {
        public enum SceneList
        {
            HUB,
            LEVEL_1_TRANSIT,
            LEVEL_1_0,
            LEVEL_2_TRANSIT,
            LEVEL_2_0,
        };
        
        public static SceneModel GetSceneByName(string name) {
            return (SceneModel) typeof(SceneCollection).GetField(name).GetValue(typeof(SceneCollection));
        }

        public static SceneModel GetSceneByName(SceneList name) {
           return GetSceneByName(name.ToString());
        }

        public static SceneModel HUB = new SceneModel
        {
            Scene = SceneList.HUB.ToString(),
            Name = "Hub",
        };
        
        public static SceneModel LEVEL_1_TRANSIT = new SceneModel
        {
            Scene = SceneList.LEVEL_1_TRANSIT.ToString(),
            Name = "Level 1 - TRANSIT",
        };

        public static SceneModel LEVEL_1_0 = new SceneModel
        {
            Scene = SceneList.LEVEL_1_0.ToString(),
            Name = "Level 1 - 0",
        };

        public static SceneModel LEVEL_2_TRANSIT = new SceneModel
        {
            Scene = SceneList.LEVEL_2_TRANSIT.ToString(),
            Name = "Level 2 - TRANSIT",
        };

        public static SceneModel LEVEL_2_0 = new SceneModel
        {
            Scene = SceneList.LEVEL_2_0.ToString(),
            Name = "Level 2 - 0",
        };

    }
}
