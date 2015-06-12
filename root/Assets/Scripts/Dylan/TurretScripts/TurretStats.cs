using UnityEngine;
using System.Collections;

public class TurretStats : Stats
{
    public enum e_TurretType
    {
        e_MachineGun,
        e_AntiAir,
        e_ShotGun,
    }

    public float rotationSpeed = 5.0f;
    public float reloadSpeed = 5.0f;
    public float rateOfFire = .25f;

    public int damage = 5;

    public GameObject bullet;
    public GameObject turretView;

    public Transform[] barrelPos;
    public Transform[] turretTop;


    // Use this for initialization
    void Start(e_TurretType type)
    {
        m_MaxHealth = 100;
        m_Health = m_MaxHealth;
        switch(type)
        {
            case e_TurretType.e_MachineGun:
                m_maxAmmo = 30;
                break;
            case e_TurretType.e_AntiAir:
                m_maxAmmo = 100;
                break;
            case e_TurretType.e_ShotGun:
                m_maxAmmo = 5;
                break;
        }
        m_Ammo = m_maxAmmo;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
