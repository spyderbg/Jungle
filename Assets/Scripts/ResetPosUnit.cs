using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ResetPosUnit : Unit
{
    [DoNotSerialize] public ControlInput inputTrigger;

    [DoNotSerialize] public ControlOutput outputTrigger;
    
    [DoNotSerialize] public ValueOutput outPosition;
    
    private Vector3 resultPosition;
    
    protected override void Definition()
    {
        inputTrigger = ControlInput("Input", Execute);

        outputTrigger = ControlOutput("Output");
        
        outPosition = ValueOutput<Vector3>("OutPosition", (flow) => resultPosition);
    }

    private ControlOutput Execute(Flow flow)
    {
        resultPosition = Vector3.zero;
        
        return outputTrigger;
    }
}
