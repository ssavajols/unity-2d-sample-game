using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiDamageCounter : GuiText {

    public GameObject ImageCount;
    public string Name = "None";
    public float Count = 0;
    public float Max = 0;

    float showTimeMax = 2f;
    float deltaTime = 0f;

    public static GuiDamageCounter Instance;

    new void Start() {
        base.Start();

        GuiDamageCounter.Instance = this;

        SetDefaultState();
        AddToGameConfiguration ();
    }

	// Update is called once per frame
	void Update () {
        UpdateDamageCounter();
        UpdateDamageImageCounter();
        UpdateDeltaTime();
        ShowCounter();
	}

    void SetDefaultState() {
        transform.localScale = new Vector3(0, 0, 0);
        deltaTime = showTimeMax;
    }

    void AddToGameConfiguration(){
        Game.Global.GuiDamageCounter = gameObject.GetComponent<GuiDamageCounter>();
    }

    public static void SetDamageCounter(string name, float count, float max) {
        GuiDamageCounter.Instance.Name = name;
        GuiDamageCounter.Instance.Count = Mathf.Min(max, Mathf.Max(0, count));
        GuiDamageCounter.Instance.Max = max;

        GuiDamageCounter.Instance.deltaTime = 0;
    }

    void UpdateDamageCounter() {
        text.text = Name + " : " + Count.ToString() + "/" + Max.ToString();    
    }

    void UpdateDeltaTime()
    {
        if (deltaTime < showTimeMax)
        {
            deltaTime += Time.deltaTime;
        }
    }

    void ShowCounter() {
        if( deltaTime < showTimeMax ) {
            transform.localScale = new Vector3(1, 1, 1);
        } else {
            transform.localScale = new Vector3(0, 0, 0);
        }
    }

    void UpdateDamageImageCounter() {
        float X = 1f;
        float Y = 1f;
        float Z = 1f;

        if( ImageCount != null && Max > 0 ) {
            X = Mathf.Min(100, Mathf.Max(0, Count / Max));
        }else {
            X = Random.Range(0, 1);
        }

        ImageCount.transform.localScale = new Vector3(X, Y, Z); 

    }
}
