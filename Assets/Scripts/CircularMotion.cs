using UnityEngine;

public class CircularMotion : MonoBehaviour
{
    public Transform targetObject;

    public float xAmplitude = 2f;
    public float yAmplitude = 2f;
    public float speed = 5f;
    private void Animate()
    {
        //Add your code here
        float positionX = xAmplitude * Mathf.Cos(speed * Time.time);
        float positionY = yAmplitude * Mathf.Sin(speed * Time.time);

        targetObject.localPosition = new Vector3(positionX, positionY, targetObject.localPosition.z);
    }

    private void Update()
    {
        if (!targetObject) return;

        Animate();
    }
}
