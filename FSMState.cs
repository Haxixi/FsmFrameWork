using UnityEngine;
using System.Collections;

public abstract class FSMState
{
    protected FSM fsm;
    protected Transform entity;

    protected PlayerFSM playerFsm;

    protected FSMState()
    {
        
    }

    protected FSMState(FSM fsm)
    {
        this.fsm = fsm;
    }

    protected FSMState(FSM fsm, Transform entity)
    {
        this.fsm = fsm;
        this.entity = entity;
        playerFsm = entity.GetComponent<PlayerFSM>();
    }

    abstract public void OnStateEnter();
    abstract public void OnStateExit();
    abstract public void TransitionListenerUpdate();
    abstract public void CurrentStateUpdate();
    abstract public void HierarchicalUpdate();
}
