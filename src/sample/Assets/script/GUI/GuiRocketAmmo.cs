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
        text.text = Game.Data.WeaponCollection.ROCKET_LAUNCHER.Name + " : " + Game.Configuration.Player.Player.RocketAmmo.ToString();
    }
}

