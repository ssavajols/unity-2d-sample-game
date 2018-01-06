using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Configuration {
    public static class GameObjectsContainer
    {
        public enum ContainerList { Bullet, Bodies };
        public static GameObject Bullets;
        public static GameObject Bodies;

        public static void SetContainer(ContainerList containerName, GameObject container) {
            switch(containerName) {
                case ContainerList.Bullet:
                    Bullets = container;
                    break;
                case ContainerList.Bodies:
                    Bodies = container;
                    break;
            }
        }
    }
} 
