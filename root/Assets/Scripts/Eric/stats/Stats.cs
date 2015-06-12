using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour
{
    //Health related
    public float m_MaxHealth, m_Health, m_HealthRegen;
    public int m_maxAmmo, m_Ammo;

    public bool isPlayer, isEnemy, isTurret, isGoal;

    void Awake()
    {
        isPlayer = isEnemy = isTurret = isGoal = false;
    }
}
