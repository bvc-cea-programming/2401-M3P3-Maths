using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    public Transform targetObject;

    public float xAmplitude = 2f;
    public float yAmplitude = 2f;
    public float speed = 5f;
    private void Animate()
    {
        float posX = xAmplitude * Mathf.Sin(Time.time * speed);
        float posY = yAmplitude * Mathf.Cos(Time.time * speed);
        targetObject.localPosition = new Vector3(posX, posY, 0);
    }

    private void Update()
    {
        if (!targetObject) return;

        Animate();
    }
}