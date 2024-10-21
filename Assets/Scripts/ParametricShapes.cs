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
        targetObject.localPosition = new Vector2(amplitude * Mathf.Sin(Time.time * speed)*Time.time, amplitude * Mathf.Cos(Time.time * speed)*Time.time);
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();

        if (targetObject.localPosition.x > 5) targetObject.localPosition = Vector3.zero;
    }
    
}
