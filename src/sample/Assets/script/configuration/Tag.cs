using UnityEngine;
using System.Collections;

namespace Game.Configuration {
    public static class Tag
    {
        public static string Untagged = "Untagged";
        public static string Player = "Player";
        public static string Ennemy = "Ennemy";
        public static string Boss = "Boss";
        public static string Bullet = "Bullet";
        public static string PlayerBullet = "PlayerBullet";
        public static string EnnemyBullet = "EnnemyBullet";
        public static string Rocket = "Rocket";
        public static string MainCamera = "MainCamera";

        public static string Compose(IList tags) {
            string tagString = "";
            // dynamically create tag to unity and return string
            for (int i = 0; i < tags.Count; i++) {
                tagString += tags[i];
            }            
            return tagString;
        }

        public static bool Detect(string tag, string pattern) {
            return tag.Contains(pattern);
        }
    }


}
