using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public Transform targetObject;
    
    public float amplitude = 3f;
    public float frequency = 2f;
    private void Animate()
    {
        //Add your code here
        float y = Mathf.Abs(amplitude * Mathf.Cos(Time.time * frequency));
        targetObject.localPosition = new Vector3(0,y,0);
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
