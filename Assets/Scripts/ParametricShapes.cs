using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class ParametricShapes : MonoBehaviour
{
    public Transform targetObject;
    public float amplitude = 0.3f;
    public float speed = 5f;
    private void Animate()
    {
        //Add your code here
        float posX = amplitude * Mathf.Cos(Time.time * speed) * Time.time;
        float posY = amplitude * Mathf.Sin(Time.time * speed) * Time.time;
        targetObject.localPosition = new Vector3(posX, posY, 0);


    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();

        if (targetObject.localPosition.x > 5) targetObject.localPosition = Vector3.zero;
    }
    
}
