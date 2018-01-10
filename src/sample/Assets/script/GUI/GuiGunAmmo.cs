using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiGunAmmo : GuiText
{

    // Update is called once per frame
    void Update()
    {
        UpdateAmmo();
    }

    void UpdateAmmo()
    {
        text.text = Game.Data.WeaponCollection.GUN.Name + " : " + Game.Configuration.Player.Player.GunAmmo.ToString();
    }
}

