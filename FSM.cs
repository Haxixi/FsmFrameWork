using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public abstract class FSM : MonoBehaviour
{
    public Dictionary<string, FSMState> Dic = new Dictionary<string, FSMState>();
    protected FSMState currentState;

    private bool isTransition;
    private float _TransitionTime;

    void Start()
    {
        InitFSM();
    }

    void Update()
    {
        UpdateFSMListener();

        UpdateFSMState();

        HierarchicalFSMUpdate();
    }

    public void MoveToState(string state, float transition)
    {
        if (isTransition)
        {
            return;
        }

        currentState.OnStateExit();

        currentState.OnStateEnter();

        isTransition = true;

        _TransitionTime += Time.deltaTime;

        if (_TransitionTime >= transition)
        {
            isTransition = false;

            currentState = Dic[state];

            _TransitionTime = 0;

        }
    }

    protected void AddState(string str, FSMState state)
    {
        Dic.Add(str, state);

        if (Dic.Count == 1)
        {
            currentState = Dic[str];
        }
    }

    public virtual void InitFSM()
    {

    }

    public void UpdateFSMListener()
    {
        if (isTransition)
        {
            return;
        }

        currentState.TransitionListenerUpdate();
    }

    public void UpdateFSMState()
    {
        currentState.CurrentStateUpdate();
    }

    public void HierarchicalFSMUpdate()
    {
        currentState.HierarchicalUpdate();
    }
}

