using System;
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
        targetObject.localPosition = new Vector2(xAmplitude * Mathf.Sin(Time.time * speed), yAmplitude * Mathf.Cos(Time.time * speed));
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
