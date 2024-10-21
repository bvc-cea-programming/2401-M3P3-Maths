using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public Transform targetObject;
    
    public float amplitude = 3f;
    public float frequency = 2f;
    private float startPosition;
    private float currentPosition;

    private void Start()
    {
        startPosition = targetObject.position.y;
    }
    private void Animate()
    {
        //Add your code here
        currentPosition = startPosition + amplitude + Mathf.Abs(Mathf.Sin(frequency * Time.time));
        targetObject.position = new Vector3(targetObject.position.x, currentPosition, targetObject.position.z);
    }

    private void Update()
    {
        if(!targetObject) return;
        
        Animate();
    }
}
