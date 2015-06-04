using UnityEngine;
using System.Collections;

public class TurretCannon : MonoBehaviour 
{

    public GameObject myProjectile;
    public GameObject muzzleEffect;

    public float error          = 0.001f;
    public float turnSpeed      = 5.0f  ;
    public float reloadSpeed    = 1.0f  ;
    public float fireingDelay   = 0.25f ;

    public Transform myTarget;
    public Transform[] muzzlePos;
    public Transform turretDome;
   
    public float aimError;
    public float nextFireTime;
    public float nextMoveTime;

    

    private Quaternion desiredRotation; 

	// Use this for initialization
	void Start() {}
	
	// Update is called once per frame
	void Update()
    {
	    if (myTarget)
        {
            if (Time.time > nextMoveTime)
            {
                CalculateAim(myTarget.position);
                turretDome.rotation = Quaternion.Lerp(turretDome.rotation, desiredRotation, Time.deltaTime * turnSpeed);
            }

            if (Time.time > nextFireTime)
            {
                FireProjectile();
            }
        }
	}

    void OnTriggerStay(Collider other)
    {
        if (!myTarget)
        {
            if (other.gameObject.tag == "Enemy")
            {
                nextFireTime = Time.time + (reloadSpeed * 0.5f);
                myTarget = other.gameObject.transform;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.transform == myTarget)
        {
            myTarget = null;
        }
    }

    void CalculateAim(Vector3 targetPos)
    {
        Vector3 aimPoint = new Vector3 (targetPos.x + aimError, targetPos.y + aimError, targetPos.z + aimError);
        aimPoint.y -= myTarget.transform.localScale.y / 2;
        desiredRotation = Quaternion.LookRotation(aimPoint - transform.position);
    }

    void CalculateError()
    {
        aimError = Random.Range(-error, error);
    }

    void FireProjectile()
    {
        nextFireTime = Time.time + reloadSpeed;
        nextMoveTime = Time.time + fireingDelay;
        CalculateError();

        foreach (Transform theMuzzlePos in muzzlePos)
        {
            Instantiate(myProjectile, theMuzzlePos.position, theMuzzlePos.rotation);
            //Instantiate(muzzleEffect, theMuzzlePos.position, theMuzzlePos.rotation);
        }
    }
}

