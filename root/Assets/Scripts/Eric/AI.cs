using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

public class AI : AICharacterControl
{
    public GameObject goal;
	// Use this for initialization
	void Start ()
    {
        goal = GameObject.FindObjectOfType<GoalStats>().gameObject;
        target = goal.transform;
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnTriggerStay (Collider other)
    {
        if (other.GetComponent<Stats>())
        {
            if (other.GetComponent<Stats>().isPlayer)
            {
                SetTarget(other.transform);
            }
            else if (other.GetComponent<Stats>().isTurret)
            {
                SetTarget(other.transform);
            }
        }
    }
}
