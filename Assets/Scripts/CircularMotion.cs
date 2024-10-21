using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    public Transform targetObject;
    
    public float xAmplitude = 2f;
    public float yAmplitude = 2f;
    public float speed = 5f;
    private void Animate()
    {
        //Add your code here
        float time = Time.time * speed; 
        float x = xAmplitude * Mathf.Cos(time);
        float y = yAmplitude * Mathf.Sin(time);

        targetObject.localPosition = new Vector3(x, y, targetObject.localPosition.z);
        
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
