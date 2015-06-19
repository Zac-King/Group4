using UnityEngine;
using System.Collections;

public class GoalHealth : MonoBehaviour 
{
    public int startingHealth = 1;
    public int currentHealth;

    void Start()
    {
        currentHealth = startingHealth;
    }
}
