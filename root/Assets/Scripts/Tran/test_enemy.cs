using UnityEngine;
using System.Collections;

public class test_enemy : MonoBehaviour {

    public Transform goal;
    NavMeshAgent agent;

	void Start () 
    {
       agent = GetComponent<NavMeshAgent>();
       
	}
	
	void Update () 
    {
        agent.destination = goal.position;
        
	}
}
