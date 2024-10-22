using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ParametricShapes : MonoBehaviour
{
    public Transform targetObject;
    public float amplitude = 0.3f;
    public float speed = 5f;
    private float time;
    private void Animate()
    {
        //Add your code here


        time += Time.deltaTime * speed;

        // Calculate new position using spiral equations
        float x = amplitude * Mathf.Cos(time) * time; // Spiral X position
        float y = amplitude * Mathf.Sin(time) * time; // Spiral Y position

        // Update local position of the GameObject
        transform.localPosition = new Vector3(x, y, transform.localPosition.z);

    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();

        if (targetObject.localPosition.x > 5) targetObject.localPosition = Vector3.zero;
    }
    
}
