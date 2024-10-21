using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    public Transform targetObject;
    
    public float xAmplitude = 2f;
    public float yAmplitude = 2f;
    public float speed = 5f;
    private float xPosition;
    private float yPosition;
    private float xStart;
    private float yStart;

    private void Start()
    {
        xStart = targetObject.position.x;
        yStart = targetObject.position.y;
    }
    private void Animate()
    {
        //Add your code here
        xPosition = xStart + xAmplitude * Mathf.Sin(speed * Time.time);
        yPosition = yStart + yAmplitude * Mathf.Cos(speed * Time.time);
        targetObject.position = new Vector3(xPosition, yPosition, targetObject.position.z);
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
