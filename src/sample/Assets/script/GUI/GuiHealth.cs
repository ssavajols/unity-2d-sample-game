using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuiHealth : GuiText
{

    // Update is called once per frame
    void Update()
    {
        UpdateHealth();
    }

    void UpdateHealth()
    {
        text.text = "Health : " + Game.Configuration.Player.Player.Health.ToString();
    }
}
