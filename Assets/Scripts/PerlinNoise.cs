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
        float time = Time.time * speed;

        float Intensify = Mathf.PerlinNoise(time, intensityMultiplier);
        targetLight.intensity = Intensify;
    }

    private void Update()
    {
        if(!targetLight) return;
        
        Animate();
    }
}
