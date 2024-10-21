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
        
        // Calculate the time using frequency to control the speed of the bounce
        float time = Time.time * frequency;

        // Calculate the Y position using Mathf.Abs to simulate a bouncing effect
        float y = Mathf.Abs(Mathf.Sin(time) * amplitude);

        // Update the target obect's Y position for the bouncing effect
        targetObject.localPosition = new Vector3(targetObject.localPosition.x, y, targetObject.localPosition.z);
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
