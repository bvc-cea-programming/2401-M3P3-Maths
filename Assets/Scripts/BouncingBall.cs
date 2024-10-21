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
        targetObject.localPosition = new Vector2 (0, amplitude * Mathf.Abs(Mathf.Sin(frequency * Time.time)));
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
