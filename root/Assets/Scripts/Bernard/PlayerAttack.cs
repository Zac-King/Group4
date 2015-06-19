using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour
{
    public int playerDamage = 1;
    public float timeBetweenThrows = 0.5f;
    public float range = 50f;

    float timer;
    Ray throwRay;
    RaycastHit throwHit;
    LineRenderer throwLine;
    int throwableMask;
    float effectsDisplayTime = 0.2f;

    public void DisableEffects()
    {
        throwLine.enabled = false;    
    }

    void Throw()
    {
        timer = 0f;

        throwLine.enabled = true;
        throwLine.SetPosition(0, transform.position);

        throwRay.origin = transform.position;
        throwRay.direction=transform.forward;

        if(Physics.Raycast(throwRay, out throwHit, range, throwableMask))
        {
            EnemyHealth enemyHealth = throwHit.collider.GetComponent<EnemyHealth>();

            if(enemyHealth!=null)
            {
                enemyHealth.TakeDamage(playerDamage, throwHit.point);
            }

            throwLine.SetPosition(1, throwHit.point);
        }

        else
        {
            throwLine.SetPosition(1, throwRay.origin + throwRay.direction * range);
        }

    }

    
    void Awake()
    {
        throwableMask = LayerMask.GetMask("Throwable");
        throwLine = GetComponent<LineRenderer>();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if(Input.GetButton("Fire1") && timer >= timeBetweenThrows)
        {
            Throw();
        }

        if(timer >= timeBetweenThrows * effectsDisplayTime)
        {
            DisableEffects();
        }
    }

}