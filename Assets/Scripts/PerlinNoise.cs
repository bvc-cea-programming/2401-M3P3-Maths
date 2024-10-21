using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoise : MonoBehaviour
{
    public Light targetLight;
    
    public float speed = 3f;
    public float intensityMultiplier = 2f;
    private void Animate()
    {
        //Add your code here
        float perlinX = Mathf.Sin(Time.time * speed);
        float perlinY = Mathf.Cos(Time.time * speed);
        targetLight.intensity = intensityMultiplier * Mathf.PerlinNoise(perlinX,perlinY);
    }

    private void Update()
    {
        if(!targetLight) return;
        
        Animate();
    }
}
