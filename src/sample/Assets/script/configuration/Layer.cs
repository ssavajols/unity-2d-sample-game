using UnityEngine;
using System.Collections;

namespace Game.Configuration {
    public static class Layer
    {
        static public string DEFAULT = "Default";
        static public string TRANSPARENT_FX = "TransparentFX";
        static public string IGNORE_RAYCAST = "Ignore Raycast";
        static public string BLANK = "";
        static public string WATER = "Water";
        static public string UI = "UI";
        static public string GROUND_OBJECTS = "groundObjects";
        static public string CHARACTERS = "characters";

        static public int GetIndexByNameLayer(string name) {
            return LayerMask.NameToLayer(name);
        }

        static public string GetNameByIndexLayer(int index) {
            return LayerMask.LayerToName(index);
        }
    }
}
