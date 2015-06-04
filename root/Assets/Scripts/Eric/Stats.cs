using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour
{
    //Player specific
    public float m_Level, m_Exp, m_ExpNeeded;
    //Health related
    public float m_MaxHealth, m_Health, m_HealthRegen;
    //Generic
    public float m_Def, m_Speed, m_Acc, m_Dam;

    //How the experience needed is incrimented per level
    public enum GrowthType
    {
        LOG,
        EXPNENTIAL,
    }
    public GrowthType cGrowthType = GrowthType.LOG;

    protected virtual void LevelUp()
    {
        m_Exp = 0;
        m_Level += 1;

        switch (cGrowthType)
        {
            case GrowthType.LOG:
                m_ExpNeeded += Mathf.Log(m_ExpNeeded);
                break;
            case GrowthType.EXPNENTIAL:
                m_ExpNeeded = (m_Level * m_Level) * 100;
                break;
        }

        m_HealthRegen += Mathf.Log(m_HealthRegen);
        m_MaxHealth += Mathf.Log(m_MaxHealth);
        m_Speed += Mathf.Log(m_Speed);
        m_Def += Mathf.Log(m_Def);
        m_Acc += Mathf.Log(m_Acc);
    }
}
