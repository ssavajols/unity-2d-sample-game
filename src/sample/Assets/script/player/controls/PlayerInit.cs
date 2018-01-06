using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Configuration.Player;
public class PlayerInit : MonoBehaviour {

    public float PlayerMoverSpeed = 0.01f;
    public GameObject FireBullet;
    public GameObject PlayerCursor;
    public GameObject PlayerWeapon;

    PlayerMover playerMover;
    PlayerActions playerActions;
    AimCursorFollow aimCursorFollow;


	// Use this for initialization
	void Start () {
        SetCurrentPlayer(gameObject);
	}

    public void SetCurrentPlayer(GameObject go) {
        PlayerConfiguration.CurrentPlayer = go;

        AddMoverScript();
        AddSortByYScript();
        AddActionsScript();
        AddAimCursorFollowScript();
    }

    void AddSortByYScript() {
        PlayerConfiguration.CurrentPlayer.AddComponent<SortByY>();
    }

    void AddMoverScript() {
        playerMover = PlayerConfiguration.CurrentPlayer.AddComponent<PlayerMover>();
        playerMover.speed = PlayerMoverSpeed;
    }

    void AddActionsScript() {
        playerActions = PlayerConfiguration.CurrentPlayer.AddComponent<PlayerActions>();
        playerActions.fireBulletGenerator = FireBullet;
    }

    void AddAimCursorFollowScript() {
        aimCursorFollow = PlayerConfiguration.CurrentPlayer.AddComponent<AimCursorFollow>();
        aimCursorFollow.FireBulletGenerator = FireBullet;
        aimCursorFollow.Cursor = PlayerCursor;
        aimCursorFollow.weapon = PlayerWeapon;
    }

	
}
