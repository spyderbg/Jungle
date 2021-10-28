using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    public Vector3 InitialPosition;
    
    private void Start()
    {
        Debug.Log($"transform.position befor: {transform.position}");
        
        transform.position = InitialPosition;
        
        Debug.Log($"transform.position after: {transform.position}");
    }

    private void Update()
    {
        
    }
}
