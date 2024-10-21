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
        float time = Time.time * speed;

        float x = amplitude * Mathf.Cos(time) * time;
        float y = amplitude * Mathf.Sin(time) * time;

        targetObject.localPosition = new Vector3(x, y, targetObject.localPosition.z);

    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();

        if (targetObject.localPosition.x > 5) targetObject.localPosition = Vector3.zero;
    }
    
}
