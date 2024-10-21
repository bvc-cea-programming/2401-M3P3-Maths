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
        float perlinX = Mathf.Sin(speed * Time.time);
        float perlinY = Mathf.Cos(speed * Time.time);
        float perlin = Mathf.PerlinNoise(perlinX, perlinY) * intensityMultiplier;
        targetLight.intensity = perlin;
    }

    private void Update()
    {
        if(!targetLight) return;
        
        Animate();
    }
}
