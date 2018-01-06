using UnityEngine;
using System.Collections;
using Game.Weapon;
using Game.Configuration;
using Game.Configuration.Player;
using Game.Configuration.Weapon;

namespace Game.Weapon
{
    public class DropArmor : MonoBehaviour
    {

        public int Amount = 100;

        protected void Start()
        {
            AddColliderComponents();
        }

        protected void AddColliderComponents()
        {
            Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D>();
            BoxCollider2D bc = gameObject.AddComponent<BoxCollider2D>();

            rb.bodyType = RigidbodyType2D.Static;
            bc.isTrigger = true;

        }

        protected void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == Tag.Player && Player.Armor < 100)
            {
                AddArmor();
                Destroy(gameObject);
            }
        }

        protected virtual void AddArmor() {
            Player.Armor = Mathf.Min(100, Player.Armor + Amount);
        }

    }
}