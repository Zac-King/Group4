using UnityEngine;
using System.Collections;

public class EnemyStats : Stats
{
    public bool m_PowerLevel;
    public int m_pLvl;

    void Start()
    {
        m_Level = 1;

        m_Acc = 1;
        m_Def = 1;
        m_Speed = 1;
        m_MaxHealth = 100;
        m_Health = m_MaxHealth;

        m_PowerLevel = false;
    }

    void TakeDamage(int amount, Vector3 hitPoint)
    {
        m_Health -= amount;
    }

    void Update()
    {
        if (m_PowerLevel)
            PowerLevel(m_pLvl);   
        
        if (Input.GetKey(KeyCode.Return))
            m_Health = m_MaxHealth - 5;
    }

    void PowerLevel(int lvl)
    {
        while (m_Level < lvl)
            LevelUp();

        m_PowerLevel = false;
            
    }
}
