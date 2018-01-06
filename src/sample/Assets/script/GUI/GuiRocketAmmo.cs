using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiRocketAmmo : GuiText
{

    // Update is called once per frame
    void Update()
    {
        UpdateAmmo();
    }

    void UpdateAmmo()
    {
        text.text = "Rocket : " + Game.Configuration.Player.Player.RocketAmmo.ToString();
    }
}

