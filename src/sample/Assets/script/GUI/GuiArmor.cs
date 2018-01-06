using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiArmor : GuiText
{

    // Update is called once per frame
    void Update()
    {
        UpdateArmor();
    }

    void UpdateArmor()
    {
        text.text = "Armor : " + Game.Configuration.Player.Player.Armor.ToString();
    }
}
