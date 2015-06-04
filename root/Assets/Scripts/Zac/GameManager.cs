using UnityEngine;
using System.Collections;
using System.Collections.Generic; 
public class GameManager : Singleton<GameManager>
{
    // Game State possible  : <Enum>
    public enum StateManager 
    { 
        INIT,
        MAINMENU,
        RUNNING,
        EXIT
    }
    // Pause State rate     : <Enum>
    public enum PauseState
    {
        Full,       // Update Halted
        Half,       // Update at half speed
        None,       // Update rate not effected
    }
    [SerializeField]
    //public List<LevelStruct> Level = new List<LevelStruct>();
    public List<string> Levels = new List<string>();

    private bool transitionPossible;
    private StateManager c_GameState;
    private PauseState   c_PauseState;
     
    /// 
    // 

    [ContextMenu("reset levels")]
    public void ResetLevels()
    {
        Levels = new List<string>();
    }
    protected override void Awake()
    {
        transitionPossible = true;
        c_GameState = StateManager.INIT;
        base.Awake();           
    }

    /// usage: GameManager.instance.Transition("Combat")
    public void Transition(string lev)
    {
        
        print("hit");   // test
        print(Application.loadedLevelName);
    }

    private bool CheckTransition(StateManager stateB)
    {
        if (c_GameState == stateB)
        {
            /// Not valid; Transistion to current state
            print("Already in this state. Check returned: False");
            return false;
        }

        else
        {
            switch (c_GameState)
            {
                // init to mainmenu check
                case StateManager.INIT:
                    if (stateB == StateManager.MAINMENU)
                        return true;
                    break;
                // mainmenu to running check
                case StateManager.MAINMENU:
                    if (stateB == StateManager.RUNNING)
                        return true;
                    break;
                // running back to mainmenu 
                case StateManager.RUNNING:
                    if (stateB == StateManager.MAINMENU)
                        return true;
                    if (stateB == StateManager.EXIT)
                        return true;
                    break;
                // Default
                default:
                    break;
            }

            return false;
        }
    }

    public void Pause(PauseState state)
    {
        string debugtext = "Blank";
        switch (state)
        {
            case PauseState.None:
                { Time.timeScale = 1; debugtext = "Full Update"; }
                break;
            case PauseState.Half:
                { Time.timeScale = 0.5f; debugtext = "Half Update"; }
                break;
            case PauseState.Full:
                { Time.timeScale = 0; debugtext = "Update Halfed"; }
                break;
            default: break;
        }
        // Debug
        print("Pause function hit. State triggered: " + debugtext);
    }

	// Use this for initialization
	void Start () 
    {
        c_GameState  = StateManager.MAINMENU;
        c_PauseState = PauseState.None;
	}
	
	// Update is called once per frame
	void Update () 
    {

	}

    [ContextMenu("do the thing i said to do")]
    public void doIt()
    {
        GameObject blah = new GameObject();
        blah.name = "doit";
        Instantiate(blah);
        print("do it dude make a go");
    }
}
