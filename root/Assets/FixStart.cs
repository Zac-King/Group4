using UnityEngine;
using System.Collections;

public class FixStart : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        HUDManager.instance.SetState("start",  true);
        HUDManager.instance.SetState("panel",  false);
        HUDManager.instance.SetState("menu",   false);
        HUDManager.instance.SetState("finish", false);

       // GameManager.instance.Pause(GameManager.PauseState.None);

    }


}
