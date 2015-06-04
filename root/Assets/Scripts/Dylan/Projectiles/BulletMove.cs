using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour 
{
    GameObject[] BB; // shots inside of a shot

    private float mySpeed = 1f;
    private float maxDistance = 4f;

    private float myDist;

    private float spreadRate = 4;

    int numOfShots = 1;

    public bool isFired = false; //a bool to check if the bullet is beign fired

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update ()
    {
        if(isFired == true)
        {
            transform.Translate(Vector3.up * Time.deltaTime * mySpeed);
            myDist += Time.deltaTime * mySpeed;

            //moves the bullet across the screen when the turret fires

            if (myDist > maxDistance)
            {
                Destroy(gameObject);
                    //checks to see if the bullet has passed the maximum distance it can travel
                    //and if it dis destroy the object
            }
        }

        if (gameObject.tag == "ShotGunShell" && isFired == true)
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            Instantiate(BB[numOfShots], transform.position, transform.rotation);

            transform.Translate(Vector3.up * Time.deltaTime * mySpeed);

            forward.x += Random.Range(spreadRate, -spreadRate);
            forward.y += Random.Range(spreadRate, -spreadRate);
            forward.z += Random.Range(spreadRate, -spreadRate);

            BB[numOfShots].transform.LookAt(forward);

            myDist += Time.deltaTime * mySpeed;
            if (myDist > maxDistance)
            {
                Destroy(gameObject);
                print("Obj Gone");
                //checks to see if the bullet has passed the maximum distance it can travel
                //and if it dis destroy the object
            }
        }
	}
}
