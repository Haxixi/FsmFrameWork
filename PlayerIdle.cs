using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdle : FSMState
{
    public PlayerIdle(FSM fsm, Transform entity) : base(fsm, entity)
    {

    }

    public override void CurrentStateUpdate()
    {

    }

    public override void HierarchicalUpdate()
    {

    }

    public override void OnStateEnter()
    {
        Debug.Log("idle enter");       
    }

    public override void OnStateExit()
    {
        Debug.Log("idle exit");
        playerFsm.Run();
    }

    public override void TransitionListenerUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            fsm.MoveToState(PlayerStateID.PlayerWalk, 2);
        }
    }
}
