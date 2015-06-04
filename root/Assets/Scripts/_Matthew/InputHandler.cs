using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InputHandler : MonoBehaviour 
{
    private GameObject player;
    private GameObject turret;
    public GameObject levelLoader; // Test Only

    public KeyCode halfPause =  KeyCode.C;
    public KeyCode pause     =  KeyCode.X;
    public KeyCode unpause   =  KeyCode.Z;
    public KeyCode slap      =  KeyCode.F;
    public KeyCode shoot     =  KeyCode.V;

    public KeyCode tTurret1 =   KeyCode.Alpha1;
    public KeyCode tTurret2 =   KeyCode.Alpha2;
    public KeyCode tTurret3 =   KeyCode.Alpha3;
    public KeyCode tTurret4 =   KeyCode.Alpha4;
    public KeyCode keyPad   =   KeyCode.KeypadEnter;

    private KeyCode TestDie = KeyCode.F5;

	// Update is called once per frame
    delegate void PauseDelegate();
    delegate void NumberDelegate(int n);
    public int num = 0; 

    NumberDelegate numMultiDel;
    
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player"); 
    }
    void Update()
    {
        TurretPlacement.instance.TurretSelect(tTurret1, tTurret2, tTurret3, tTurret4); // Input for Turret

        if (Input.GetKeyDown(halfPause))
        {
            /// Pause State Half (Update at Half speed)
            GameManager.instance.Pause(GameManager.PauseState.Half);
        }

        if (Input.GetKeyDown(pause))
        {
            //numMultiDel = null;
            //num++;
            //numMultiDel += NumberPlusFive;
            //numMultiDel += NumberSquared;
            //numMultiDel(num);

            GameManager.instance.Pause(GameManager.PauseState.Full);
        }

        if(Input.GetKeyDown(pause))
        {
            GameManager.instance.Pause(GameManager.PauseState.None);
        }


        ////Player States
        if (Input.GetKeyDown(KeyCode.W)) //Walk forwrad
        {
            player.GetComponent<PlayerActions>().State(PlayerState.walk);
        }

        if (Input.GetKeyDown(KeyCode.A)) //Walk to the left
        {
            player.GetComponent<PlayerActions>().State(PlayerState.walk);
        }

        if (Input.GetKeyDown(KeyCode.S)) //Walk backwards
        {
            player.GetComponent<PlayerActions>().State(PlayerState.walk);
        }

        if (Input.GetKeyDown(KeyCode.D)) //Walk to the right
        {
            player.GetComponent<PlayerActions>().State(PlayerState.walk);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift)) //toggles run
        {
            player.GetComponent<PlayerActions>().State(PlayerState.run);
        }

        if (Input.GetKeyDown(KeyCode.I)) //toggles idles
        {
            player.GetComponent<PlayerActions>().State(PlayerState.idle);
        }

        if (Input.GetKeyDown(KeyCode.O)) //toggles init
        {
            player.GetComponent<PlayerActions>().State(PlayerState.init);
        }

        ////Player Actions
        if (Input.GetKeyDown(KeyCode.F))
        {
            player.GetComponent<PlayerActions>().Slap();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            player.GetComponent<PlayerActions>().Shoot();
        }     



        // Test Only [Not in Final]
        if(Input.GetKeyDown(TestDie))
        {
            // 
            levelLoader.GetComponent<LevelLoader>().loadLevel("Outro");
        }
    }       
}