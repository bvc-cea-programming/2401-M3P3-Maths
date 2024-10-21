using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    public Transform targetObject;
    
    public float xAmplitude = 2f;
    public float yAmplitude = 2f;
    public float speed = 5f;
    private float positionX;
    private float positionY;
    private float positionZ;
    private void Animate()
    {
        //Add your code here
        positionX = xAmplitude * Mathf.Sin(Time.time * speed);
        positionY = yAmplitude * Mathf.Cos(Time.time * speed);
        positionZ = transform.position.z;
        targetObject.localPosition = new Vector3(positionX, positionY, positionZ);
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
