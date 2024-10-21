using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public Transform targetObject;

    public float amplitude = 3f;
    public float frequency = 2f;
    private void Animate()
    {
        float pos = amplitude * Mathf.Sin(Time.time * frequency);

        targetObject.localPosition = new Vector3(0, Mathf.Abs(pos), 0);

    }

    private void Update()
    {
        if (!targetObject) return;

        Animate();
    }
}
