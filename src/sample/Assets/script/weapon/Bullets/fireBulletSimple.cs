using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Configuration;
using Game.Configuration.Weapon;

public class fireBulletSimple : MonoBehaviour {

    public WeaponModel Weapon;

    protected float speed = 10f;
    protected Rigidbody2D rb;

    protected void Start () {
        getRigidbody();
        move();
	}

    protected void getRigidbody() {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    protected  void OnCollisionEnter2D(Collision2D collision)
    {
        Hit(collision.gameObject);
    }

    protected  void OnTriggerEnter2D(Collider2D collision)
    {
        Hit(collision.gameObject);
    }

    protected void Hit(GameObject collider) {
        bool isPlayer = collider.tag == Tag.Player;
        bool isEnnemy = collider.tag == Tag.Ennemy;
        bool isBoss = collider.tag == Tag.Boss;
        bool isWall = collider.tag == Tag.Untagged;
        bool isPlayerBullet = gameObject.tag == Tag.PlayerBullet;
        bool isEnnemyBullet = gameObject.tag == Tag.EnnemyBullet;

        bool destroy = false;

        destroy = (isPlayer && isEnnemyBullet) || destroy;
        destroy = (isEnnemy && isPlayerBullet) || destroy;
        destroy = (isBoss && isPlayerBullet) || destroy;
        destroy = (isWall) || destroy;
        //destroy = (isEnnemy && isEnnemyBullet) || destroy;

        if ( destroy ) {
            ApplyDamage(collider);
            Destroy(gameObject);    
        } 
    }

    protected void ApplyDamage(GameObject go) {
        if( go.tag == Tag.Player ) {
            PlayerActions actions = go.GetComponent<PlayerActions>();    
            actions.ApplyDamage(Weapon);
        }  
        
        if( go.tag == Tag.Ennemy ) {
            EnnemyActions actions = go.GetComponent<EnnemyActions>();    
            actions.ApplyDamage(Weapon);
        }  

        if( go.tag == Tag.Boss ) {
            EnnemyActions actions = go.GetComponent<EnnemyActions>();    
            actions.ApplyDamage(Weapon);
        }  
    } 

    protected void move() {
        rb.velocity = transform.right * speed;
    }
}
