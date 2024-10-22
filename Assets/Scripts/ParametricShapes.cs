using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class ParametricShapes : MonoBehaviour
{
    public Transform targetObject;
    public float amplitude = 0.3f;
    public float speed = 5f;
    private float positionX;
    private float positionY;
    private float positionZ;
    private void Animate()
    {
        //Add your code here
        positionX = amplitude * Mathf.Sin(Time.time * speed) * Time.time;
        positionY = amplitude * Mathf.Cos(Time.time * speed) * Time.time;
        positionZ = transform.position.z;
        targetObject.localPosition = new Vector3(positionX, positionY, positionZ);
    }

    private void Update()
    {
        if (!targetObject) return;

        Animate();

        if (targetObject.localPosition.x > 5) targetObject.localPosition = Vector3.zero;
    }

}
