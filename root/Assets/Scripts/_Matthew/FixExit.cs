using UnityEngine;
using System.Collections;

public class FixExit : MonoBehaviour {

	// Use this for initialization
	void Start () {
        HUDManager.instance.SetState("start",  false);
        HUDManager.instance.SetState("panel",  false);
        HUDManager.instance.SetState("menu",   false);
        HUDManager.instance.SetState("finish", true);
        print("fix exit");
        //GameManager.instance.Pause(GameManager.PauseState.Full);

	}
	
}
