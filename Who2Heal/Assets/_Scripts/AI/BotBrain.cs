﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotBrain : UnitController 
{
    [SerializeField]
    private ABotBehaviour[] orderedBehaviours;

    protected override void Update()
    {
        base.Update();
        foreach(ABotBehaviour behaviour in orderedBehaviours)
        {
            if(behaviour.ShouldProcessUpdate())
            {
                behaviour.ProcessUpdate(this.unitMover);
                return;
            }
        }
    }
}
