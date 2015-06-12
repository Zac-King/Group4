using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    private float damage = 10;

    void OnTriggerStay (Collider other)
    {
        print("1");
        if (other.GetComponent<Stats>())
        {
            print("2");
            if (other.GetComponent<Stats>().isPlayer || other.GetComponent<Stats>().isTurret)
            {
                print("3");
                other.GetComponent<Stats>().m_Health -= (damage * Time.deltaTime);
            }
        }
    }
}
