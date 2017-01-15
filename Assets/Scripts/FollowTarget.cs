using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class FollowTarget : MonoBehaviour {

    public Transform target;
    NavMeshAgent agent;
	// Use this for initialization
	void Start ()
    {
        agent = this.GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
            agent.SetDestination(target.position);
	}
}
