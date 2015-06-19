using UnityEngine;
using System.Collections;



public class GUIManager : Singleton<GUIManager>
{

    public void ChangeLvlTo(string name)
    {
       ///

    }

    public void ExitGame()
    {
        //gameManager Function for leaving
     
    }


    /// <summary>
    ///  Pass in a bool and it will set current object based on True(active) or False(inactive)
    /// </summary>
    /// <param name="curHp"></param>
    /// <param name="maxHp"></param>
    public void SetState(GameObject go, bool state)
    {
        go.SetActive(state);
    }

    /// <summary>
    /// Pass in a GameObject if its on itll turn off if its off itll turn on.
    /// </summary>
    /// <param name="go"></param>
    public void SetState(GameObject go)
    {
        if (go.activeSelf == true)
            SetState(go, false);
        else
            SetState(go, true);
    }



}
