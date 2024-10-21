using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public Transform targetObject;
    
    public float amplitude = 3f;
    public float frequency = 2f;
    private void Animate()
    {
        //Add your code here
        float time = Time.time * frequency;
        float y = Mathf.Abs(Mathf.Sin(time)) * amplitude;

        targetObject.transform.position = new Vector3(targetObject.transform.position.x, y, targetObject.transform.position.z);
        
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
