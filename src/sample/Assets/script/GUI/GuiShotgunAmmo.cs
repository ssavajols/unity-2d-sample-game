using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiShotgunAmmo : GuiText
{

    // Update is called once per frame
    void Update()
    {
        UpdateAmmo();
    }

    void UpdateAmmo()
    {
        text.text = Game.Data.WeaponCollection.SHOTGUN.Name + " : " + Game.Configuration.Player.Player.ShotgunAmmo.ToString();
    }
}

