using UnityEngine;

public class AccelerometerInput_ExampleOne : MonoBehaviour
{
    public float speed = 0.1f;

    void Update()
    {
        transform.Translate(Input.acceleration.x * speed, Input.acceleration.y * speed, 0);
    }
}
