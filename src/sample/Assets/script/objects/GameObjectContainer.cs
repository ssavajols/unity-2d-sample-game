using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Configuration;

public class GameObjectContainer : MonoBehaviour {

    public GameObjectsContainer.ContainerList ContainerName;

	// Use this for initialization
	void Start () {
        GameObjectsContainer.SetContainer(ContainerName, gameObject);
	}
	
}
