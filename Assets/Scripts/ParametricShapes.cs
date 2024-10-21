using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ParametricShapes : MonoBehaviour
{
    public Transform targetObject;
    public float amplitude = 0.3f;
    public float speed = 5f;
    public float time;
    private void Animate()
    {
        time += 0.05f;
        time %= 15;
        //Add your code here
        float x = amplitude * Mathf.Sin(time * speed) * time;
        float y = amplitude * Mathf.Cos(time * speed) * time;

        targetObject.localPosition = new Vector3(x, y, 0);
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();

        if (targetObject.localPosition.x > 5) targetObject.localPosition = Vector3.zero;
    }
    
}
