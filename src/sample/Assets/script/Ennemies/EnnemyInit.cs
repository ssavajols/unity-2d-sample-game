using UnityEngine;
using System.Collections;
using Game.Configuration.Ennemy;

public class EnnemyInit: MonoBehaviour
{

    public GameObject fireBulletGenerator;
    public float MoverSpeed = 0.1f;
    
    protected EnnemyModel Ennemy;
    protected EnnemyAI EnnemyAI;

    protected EnnemyMover EnnemyMover;
    protected EnnemyActions EnnemyActions;

	// Use this for initialization
	protected void Start()
	{
        AddMover();
        AddActions();
        AddAIScript();
        AddSortByYScript();
	}

    protected void AddActions() {
        EnnemyActions = gameObject.AddComponent<EnnemyActions>();
        EnnemyActions.fireBulletGenerator = fireBulletGenerator;
        EnnemyActions.Ennemy = Ennemy;
    }

    protected void AddSortByYScript() {
        gameObject.AddComponent<SortByY>();
    }

    protected void AddAIScript()
    {
        EnnemyAI = gameObject.AddComponent<EnnemyAI>();
        EnnemyAI.speed = MoverSpeed;
    }

    protected void AddMover() {
        EnnemyMover = gameObject.AddComponent<EnnemyMover>();
    }
}
