using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    public Transform targetObject;
    
    public float xAmplitude = 2f;
    public float yTime = 2f;
    public float speed = 5f;
    private void Animate()
    {
        //Add your code here
        yTime += Time.deltaTime * speed;

        // Calculate the new position
        float x = xAmplitude * Mathf.Sin(yTime);
        float y = xAmplitude * Mathf.Cos(yTime);

        // Set the new position
        transform.localPosition = new Vector3(x, y, transform.localPosition.z);

    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
