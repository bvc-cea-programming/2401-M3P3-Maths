using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ParametricShapes : MonoBehaviour
{
    public Transform targetObject;
    public float amplitude = 0.3f;
    public float speed = 5f;
    private void Animate()
    {
        //Add your code here

        // Use Time.time directly but clamp it within a repeat cycle to prevent infinite growth 
        float time = Mathf.Repeat(Time.time * speed, 18f); // The 18f here defines the reset cycle

        // Calculate X and Y positions using parametric equations
        float x = amplitude * Mathf.Cos(time) * time;
        float y = amplitude * Mathf.Sin(time) * time;

        // Set the target object's local position to simulate paremetric motion
        targetObject.localPosition = new Vector3(x, y, targetObject.localPosition.z);
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();

        if (targetObject.localPosition.x > 5) targetObject.localPosition = Vector3.zero;
    }
    
}
