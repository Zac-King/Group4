using UnityEngine;
using System.Collections;

public class Spiketrap : MonoBehaviour 
{
    private float speed = 2f;

    private float range = 1;
    private float currentHeight;

    private int contactDamage = 10;

    private float damageOverTime;
    private int poisionDmg = 1;

    private bool isActive = true;
    private bool takingDoT = false;

    private float activeTime;
    private float deActiveTime;

    public void OnTriggerEnter(Collider c)
    {
        if(poisionDmg != 0)
        {
            damageOverTime = Time.time + 3;
            if(Time.time > damageOverTime && takingDoT == false)
            {
                //c.gameObject.GetComponent<PlayerStats>().HP -= poisionDmg;
                takingDoT = true;
            }
            else
            {
                takingDoT = false;
            }
        }
        else
        {
            //c.gameObject.GetComponent<PlayerStats>().HP -= contactDamage;
        }
    }

	// Use this for initialization
	void Start () { }
	
	// Update is called once per frame
	void Update ()
    {
        if (Time.time > deActiveTime && isActive == false)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
            currentHeight += Time.deltaTime * speed;

            if (currentHeight >= range)
            {
                isActive = true;
                activeTime = Time.time + 2;
            }
        }

        if (Time.time > activeTime && isActive == true)
        {
            transform.Translate((Vector3.up * Time.deltaTime * speed) * -1);
            currentHeight -= Time.deltaTime * speed;
            print("Going Down");

            if(currentHeight <= 0)
            {
                isActive = false;
                deActiveTime = Time.time + 1;
            }
        }
	}
}
