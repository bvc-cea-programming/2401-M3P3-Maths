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
        float noise = Mathf.PerlinNoise(speed, Time.time);
        targetLight.intensity = Mathf.Lerp(1f,intensityMultiplier, noise);
    }

    private void Update()
    {
        if(!targetLight) return;
        
        Animate();
    }
}
