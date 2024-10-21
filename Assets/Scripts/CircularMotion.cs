using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    public Transform targetObject;
    
    public float xAmplitude = 2f;
    public float yAmplitude = 2f;
    public float speed = 5f;

    private void Animate()
    {
        //Add your code here

        // Time value to drive the motion
        float time = Time.time * speed;

        // Calculate new X and Y positions using sine and cosine for circular motion
        float x = xAmplitude * Mathf.Sin(time);
        float y = yAmplitude * Mathf.Cos(time);

        // Set the target object's local position to create circular motion
        targetObject.localPosition = new Vector3(x, y, targetObject.localPosition.z);
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
