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
        float x = 0;
        float y = Mathf.Abs(amplitude * Mathf.Cos(Time.time * frequency));
        float z = transform.localPosition.z;
        targetObject.localPosition = new Vector3(x,y,z);
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
