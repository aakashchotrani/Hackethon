using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class Enemy : MonoBehaviour {

    Animator EnemyAnimator;
    public bool isAlive = true;
    NavMeshAgent enemyNavMeshAgent;
    AudioSource enemyAudioSource;
    Collider enemyCollider;
	// Use this for initialization
	void Start ()
    {
        EnemyAnimator = GetComponent<Animator>();
        enemyNavMeshAgent = GetComponent<NavMeshAgent>();
        enemyAudioSource = GetComponent<AudioSource>();
        enemyCollider = GetComponent<Collider>();
        isAlive = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isAlive == false)
        {
            EnemyAnimator.SetInteger("state", 3);
            enemyNavMeshAgent.speed = 0.0f;
            enemyAudioSource.enabled = false;
            enemyCollider.enabled = false;
            Destroy(this.gameObject, 5.0f);
        }

	}


    void OnTriggerEnter(Collider collider)
    {

        if (collider.tag == "Player")
        {
            EnemyAnimator.SetInteger("state", 2);
            collider.GetComponent<Player>().PlayerHealth -= 20;
            Debug.Log("state : 2");
           // Debug.Log("attack player");
        }
      
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.name == "Player")
        {
            EnemyAnimator.SetInteger("state", 1);
        }
    }

}
