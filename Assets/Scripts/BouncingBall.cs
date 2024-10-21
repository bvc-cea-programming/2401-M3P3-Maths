using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public Transform targetObject;
    
    public float amplitude = 3f;
    public float frequency = 2f;
    private void Animate()
    {
        //Add your code here
        float newY = Mathf.Abs(Mathf.Sin(Time.time * frequency) * amplitude);
        Vector3 newPosition = targetObject.localPosition;
        newPosition.y = newY;
        targetObject.localPosition = newPosition;   
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
