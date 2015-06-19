using UnityEngine;
using System.Collections;

public class EnemyMovementToGoal : MonoBehaviour 
{
    Transform goal;
    Transform goal1;
    Transform goal2;

    GoalHealth goalHealth;
    bool GoalInRange;
    NavMeshAgent nav;

	void Awake () 
    {
        goal = GameObject.FindGameObjectWithTag("Target").transform;
        goal1 = GameObject.FindGameObjectWithTag("Target1").transform;
        goal2 = GameObject.FindGameObjectWithTag("Target2").transform;

        goalHealth = goal.GetComponent<GoalHealth>();
        nav = GetComponent<NavMeshAgent>();
	}
	
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject==goal)
        {
            GoalInRange = true;
        }

        else if (other.gameObject==goal1)
        {
            GoalInRange=true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject==goal)
        {
            GoalInRange = false;
        }
    }

	void Update () 
    {
	    if(goalHealth.currentHealth>0)
        {
            nav.SetDestination(goal.position);
        }

        else
        {
            nav.enabled = false;
        }

	}
}
