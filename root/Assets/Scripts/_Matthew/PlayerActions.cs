using UnityEngine;
using System.Collections;

public class PlayerActions : MonoBehaviour, IActions
{ 
    void Awake()
    {
        fsm = new PlayerFSM();
        _instance = this;
    }
    public void Slap()
    {
        if (fsm.CurrentState != PlayerState.run || fsm.CurrentState != PlayerState.init)
        print("slap");
    }

    public void Jump()
    {
        if(fsm.CurrentState != PlayerState.init)
        print("jump");
    }

    public void Shoot()
    {
        if (fsm.CurrentState != PlayerState.init)
        print("shoot");
    }

    public void PlaceTurret()
    {
        if (fsm.CurrentState != PlayerState.run || fsm.CurrentState != PlayerState.init)
        print("turret plae");
       // GetComponent<TurretPlacement>().TurretSelect();
    }



    public void State(PlayerState state)
    {
        fsm.ChangeState(state);
    }

    protected static  PlayerActions _instance;
    private PlayerFSM fsm;

    public static PlayerActions instance
    {
        get
        {            
            return _instance;
        }
    }



}
