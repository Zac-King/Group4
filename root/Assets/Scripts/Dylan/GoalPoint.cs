using UnityEngine;
using System.Collections;

public class GoalPoint : Stats
{
    void Start()
    {
        m_Health = 100;
    }

    void Destroy()
    {
        Destroy(gameObject);
        GetComponent<LevelLoader>().loadLevel("Exit");
    }

    public void Update()
    {
        if(m_Health <= 0)
        {
            Destroy();
        }
    }
}