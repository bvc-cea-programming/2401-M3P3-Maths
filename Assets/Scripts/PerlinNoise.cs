using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerlinNoise : MonoBehaviour
{
    public Light targetLight;
    //https://docs.unity3d.com/ScriptReference/Mathf.PerlinNoise.html
    public float speed = 3f;
    public float intensityMultiplier = 2f;
    private void Animate()
    {
        //Add your code here
        float time = Time.time * speed;

        float noiseValue = Mathf.PerlinNoise(time, 0.0f);

        targetLight.intensity = noiseValue * intensityMultiplier;
        
    }

    private void Update()
    {
        if(!targetLight) return;
        
        Animate();
    }
    //notes for me
    //multiplying time by speed will adjust the rate in which noise is calculated
    //intensity multiplier is for how bright and dull the light is and now multiplying it with noisevalue i create 
    //the flicker effect but using the sum for the light intensity 
}
