using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ParametricShapes : MonoBehaviour
{
    public Transform targetObject;
    public float amplitude = 0.3f;
    public float speed = 5f;
    
    //https://stackoverflow.com/questions/47971942/drawing-y-sin%CE%B8-cos%CE%B8-in-c-sharp-with-a-pen
    private void Animate()
    {
        float time = Time.time;
        //Add your code here
        float newXPos = amplitude * Mathf.Cos(time * speed) * time;
        float newYPos= amplitude * Mathf.Sin(time * speed) * time;
        
        targetObject.localPosition = new Vector3(newXPos, newYPos, targetObject.localPosition.z);
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();

        if (targetObject.localPosition.x > 5) targetObject.localPosition = Vector3.zero;
    }
    //same logic as the last one but as the time increases the radius over time giving a spiral look
    
}
