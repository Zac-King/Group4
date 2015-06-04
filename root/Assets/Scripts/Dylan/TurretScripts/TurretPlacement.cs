using UnityEngine;
using System.Collections;

public class TurretPlacement : Singleton<TurretPlacement> 
{
    public GameObject turret1, turret2, turret3, turret4;
    public GameObject dot;
    private GameObject turret;

    public bool isSelected = false; //checks to see if a turret is selected



	// Use this for initialization
	void Start () 
    {
       // dot.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
    void Update()
    {
        //TurretSelect();
        //TurretPlace();
        //calls in the functions for selecting a turret and placing the turrets
    }

     public void TurretPlace()
    {
        Vector3 pos = transform.position + Camera.main.transform.forward * 3;
        pos.y = 1;
        //Sets the spawn position that the turret will be placed at

        if (Input.GetMouseButtonDown(0))
        {
            dot.gameObject.SetActive(true);
        }

        if (Input.GetMouseButtonUp(0) && isSelected == true)
        {
            dot.gameObject.SetActive(false);
            Instantiate(turret, pos, transform.rotation);
            isSelected = false;
        }

        if(Input.GetMouseButtonUp(0))
        {
            dot.gameObject.SetActive(false);
        }
    }

    public void TurretSelect(KeyCode a, KeyCode b, KeyCode c, KeyCode d)
    {
        if (Input.GetKeyDown(a)) 
            // Player will press #1 - 4 keys to select which type of turret they would like to choose.  
        {
            print("Turret 1 Selected.");
            // The turret placement will be placed in front of the player by 1 unit.
            turret = turret1;
            isSelected = true;
        }

        if (Input.GetKeyDown(b))
        {
            print("Turret 2 Selected.");
            turret = turret2;
            isSelected = true;
        }

        if (Input.GetKeyDown(c))
        {
            print("Turret 3 Selected.");
            turret = turret3;
            isSelected = true;
        }

        if (Input.GetKeyDown(d))
        {
            print("Turret 4 Selected.");
            turret = turret4;
            isSelected = true;
        }
    }
}
