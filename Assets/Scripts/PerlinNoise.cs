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
        float positionX = Mathf.Sin(Time.time * speed);
        float positionY = Mathf.Cos(Time.time * speed);
        float changeLight = Mathf.PerlinNoise(positionX, positionY) * intensityMultiplier;
        targetLight.intensity = changeLight;
    }

    private void Update()
    {
        if(!targetLight) return;
        
        Animate();
    }
}
