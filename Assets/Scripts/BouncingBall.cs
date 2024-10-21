using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public Transform targetObject;
    
    public float amplitude = 3f;
    public float frequency = 2f;
    private float posY;
    private void Animate()
    {
        //Add your code here
        posY = amplitude * Mathf.Sin(Time.time * frequency);
        targetObject.localPosition = new Vector3(0, Mathf.Abs(posY), 0);
    }
    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
