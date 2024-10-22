using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PerlinNoise : MonoBehaviour
{
    public Light targetLight;

    public float speed = 3f;
    public float intensityMultiplier = 2f;
    public Light pointLight;

    private float timeOffset;



     void start()
    {
        timeOffset = Random.Range(0f, 100f);
    }
    private void Animate()
    {
        //Add your code here

        float x = Time.time * speed + timeOffset;

        // Generate a Perlin noise value and scale it
        float noiseValue = Mathf.PerlinNoise(x, 0f);
        pointLight.intensity = noiseValue * intensityMultiplier; // Set light intensity

    }

    private void Update()
    {
        if(!targetLight) return;
        
        Animate();
    }
}
