using UnityEngine;
using System.Collections;

public class FieldOfView : MonoBehaviour 
{
    public bool isTargetInView = false;

    public void OnTriggerEnter()
    {
        isTargetInView = true;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
