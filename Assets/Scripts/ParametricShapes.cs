using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ParametricShapes : MonoBehaviour
{
    public Transform targetObject;
    public float amplitude = 0.3f;
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
        xPosition = xStart + amplitude * Mathf.Cos(speed * Time.time) * Time.time;
        yPosition = yStart + amplitude * Mathf.Sin(speed * Time.time) * Time.time;
        targetObject.position = new Vector3(xPosition, yPosition, targetObject.position.z);
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();

        if (targetObject.localPosition.x > 5) targetObject.localPosition = Vector3.zero;
    }
    
}
