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
        float positionX = amplitude * Mathf.Cos(speed * Time.time) * Time.time;
        float positionY = amplitude * Mathf.Sin(speed * Time.time) * Time.time;

        targetObject.localPosition = new Vector3(positionX, positionY, targetObject.localPosition.z);
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();

        if (targetObject.localPosition.x > 5) targetObject.localPosition = Vector3.zero;
    }
    
}
