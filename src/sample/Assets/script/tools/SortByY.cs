using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class SortByY : MonoBehaviour {

    SpriteRenderer SpriteRenderer;
    SortingGroup SortingGroup;

    void Start() {
        GetSpriteRenderer();
        GetSortingGroup();
    }

	void Update () {
        SetSortingOrder();
	}
    
    void GetSpriteRenderer() {
        SpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void GetSortingGroup()
    {
        SortingGroup = GetComponent<SortingGroup>();
    }

    void SetSortingOrder() {

        int Y = Mathf.RoundToInt(transform.position.y * 100f / 3) * -1;

        if( SpriteRenderer != null ) {
            SpriteRenderer.sortingOrder = Y;            
        }

        if( SortingGroup != null ) {
            SortingGroup.sortingOrder = Y;    
        }

    }


}
