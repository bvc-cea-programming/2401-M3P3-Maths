using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public Transform targetObject;
    //https://discussions.unity.com/t/making-object-move-in-sine-wave/874188
    
    public float amplitude = 3f;
    public float frequency = 2f;
    private void Animate()
    {
        float newYpos = Mathf.Abs(Mathf.Sin(Time.time * frequency)) * amplitude;
        
        targetObject.position = new Vector3(targetObject.position.x, newYpos, targetObject.position.z);
    }
    
    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
    //notes for me 
    // mathf.sin creates a repeating smooth motion between -1 and 1
    // by multiplying time by frequency i can control the sine wave speed ( higher the frequency the faster the ball bounce)
    //mathf.abs returns the sine wave result value
    //amplitude is for how high the ball bounce.
}
