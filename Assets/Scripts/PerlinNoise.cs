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

        // Generate a Perlin noise value using time and speed to make it change over time
        float noise = Mathf.PerlinNoise(Time.time * speed, 0f);

        // Adjust the light intensity using the Perlin noise value and intensityMultiplier
        targetLight.intensity = noise * intensityMultiplier;
    }

    private void Update()
    {
        if(!targetLight) return;
        
        Animate();
    }
}
