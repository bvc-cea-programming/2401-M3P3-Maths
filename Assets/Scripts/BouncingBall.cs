using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public Transform targetObject;
    
    public float xAmplitude = 3f;
    public float frequency = 2f;
    private float yTime;
    private float speed = 1f;
    private void Animate()
    {
        //Add your code here\
        yTime += Time.deltaTime * speed;

        // Calculate the new position
        float x = xAmplitude * Mathf.Sin(yTime); // Horizontal motion
        float y = Mathf.Abs(xAmplitude * Mathf.Sin(yTime)); // Vertical bouncing effect

        // Set the new position
        transform.localPosition = new Vector3(x, y, transform.localPosition.z);
        

    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
