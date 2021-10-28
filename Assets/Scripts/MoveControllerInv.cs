using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;

public class MoveControllerInv : Unit
{
    [DoNotSerialize] public ControlInput inputTrigger;

    [DoNotSerialize] public ControlOutput outputTrigger;

    [DoNotSerialize] public ValueInput moveStep;

    [DoNotSerialize] public ValueInput inPosition;

    // [DoNotSerialize] public ValueInput gameObject;

    [DoNotSerialize] public ValueOutput outPosition;

    private Vector3 resultPosition;
    
    protected override void Definition()
    {
        inputTrigger = ControlInput("Input", Execute);

        outputTrigger = ControlOutput("Output");

        moveStep = ValueInput<float>("MoveStep", 0.1f);

        inPosition = ValueInput<Vector3>("InPosition", Vector3.zero);

        // gameObject = ValueInput<GameObject>("Object");

        outPosition = ValueOutput<Vector3>("OutPosition", (flow) => { return resultPosition; });
    }

    private ControlOutput Execute(Flow flow)
    {
        var step = flow.GetValue<float>(moveStep);
        var pos = flow.GetValue<Vector3>(inPosition);
        // var obj = flow.GetValue<GameObject>(gameObject);

        pos.x -= step;
        resultPosition = pos;

        // obj.transform.position = pos;
        
        return outputTrigger;
    }
}
