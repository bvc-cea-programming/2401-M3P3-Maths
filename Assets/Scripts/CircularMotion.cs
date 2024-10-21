using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UIElements;

public class CircularMotion : MonoBehaviour
{
    public Transform targetObject;

    public float xAmplitude = 2f;
    public float yAmplitude = 2f;
    public float speed = 1f;
    public float angle;
    private void Animate()
    {
        float x = xAmplitude * Mathf.Sin(Time.time * speed);
        float y = yAmplitude * Mathf.Cos(Time.time * speed);
        float z = transform.position.z;

        targetObject.localPosition = new Vector3(x,y,z);
        //Add your code here
        /* Position X = xAmplitude * Mathf.Sin(Time * Speed)
           Position Y = yAmplitude * Mathf.Cos(Time * Speed)*/
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
