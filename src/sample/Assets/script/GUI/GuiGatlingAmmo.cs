using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiGatlingAmmo : GuiText
{

    // Update is called once per frame
    void Update()
    {
        UpdateAmmo();
    }

    void UpdateAmmo()
    {
        text.text = "Gatling : " + Game.Configuration.Player.Player.GatlingAmmo.ToString();
    }
}

