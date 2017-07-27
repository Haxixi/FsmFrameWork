using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : FSMState
{
    public PlayerWalk(FSM fsm, Transform entity) : base(fsm, entity)
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
        Debug.Log("walk enter");
    }

    public override void OnStateExit()
    {
        Debug.Log("walk exit");
    }

    public override void TransitionListenerUpdate()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            fsm.MoveToState(PlayerStateID.PlayerIdle, 3);
        }
    }
}
