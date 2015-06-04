using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    float chp = 9000;
    float mhp = 9000;
    float scraps = 9000;
    int fat = 0;

    // Use this for initialization
    void Start()
    {
        ScoreManager.instance.Hp(chp,mhp);
        ScoreManager.instance.Scrap(scraps);
       
    }

    // Update is called once per frame
    void Update()
    {  
        chp++;
        mhp++;
        scraps++;
      
        if(chp > 11000)
        {
            chp++;
            mhp++;
            scraps++;
        }


        ScoreManager.instance.Hp(chp, mhp);
        ScoreManager.instance.Scrap(scraps);




        if(Input.GetKeyDown(KeyCode.E))
        {
            fat++;
            HUDManager.instance.LogUp("Test:  " + fat.ToString());
            HUDManager.instance.PrompDis("Test");
        }
         if(Input.GetKeyDown(KeyCode.Q))
             HUDManager.instance.PrompDis("Test2");


    }



}
