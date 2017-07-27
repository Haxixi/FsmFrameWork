using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFSM : FSM
{
    public override void InitFSM()
    {
        AddState(PlayerStateID.PlayerIdle, new PlayerIdle(this, transform));
        AddState(PlayerStateID.PlayerWalk, new PlayerWalk(this, transform));
    }

    public void Run()
    {
        Debug.Log(" i   am  run");
    }
}
