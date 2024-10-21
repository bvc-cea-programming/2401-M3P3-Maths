using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public Transform targetObject;
    
    public float amplitude = 3f;
    public float frequency = 2f;
    private void Animate()
    {
        //Add your code here
        float positionY = Mathf.Abs(amplitude * Mathf.Sin(frequency * Time.time));

        targetObject.localPosition = new Vector3(targetObject.localPosition.x, positionY, targetObject.localPosition.z);
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
