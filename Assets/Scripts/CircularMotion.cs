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
       
       

        float posX = xAmplitude * Mathf.Sin(Time.time * speed);
        float posY = yAmplitude * Mathf.Cos(Time.time * speed);

        
        transform.localPosition = new Vector3(posX, posY, transform.localPosition.z);
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
