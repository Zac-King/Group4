using UnityEngine;
using System.Collections;



public class GUIManager : Singleton<GUIManager>
{

    public void ChangeLvlTo(string name)
    {
        //gameManager Function for changing scene(Level)
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



}
