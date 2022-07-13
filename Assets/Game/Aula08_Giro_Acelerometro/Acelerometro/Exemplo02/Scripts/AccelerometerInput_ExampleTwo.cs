using UnityEngine;
using UnityEngine.UI;

public class AccelerometerInput_ExampleTwo : MonoBehaviour
{
    public float speed = 200f;

    private bool supports;

    public Vector3 accelerometerValue; // Valor do acelerômetro
    public Vector3 accelerometerSmoothedValue; // Valor suavizado do acelerômetro 

    void Start()
    {
        accelerometerSmoothedValue = Vector3.zero;

        supports = SystemInfo.supportsAccelerometer;
    }

    void Update()
    {
        if (supports)
        {
            accelerometerValue = Input.acceleration;

            // Suavização da transição entre acelerações (interpolação)
            accelerometerSmoothedValue = Vector3.Lerp(accelerometerSmoothedValue, accelerometerValue, Time.deltaTime); // Time.deltaTime: tempo de carregamento de um frame a outro, cerca de 0.01 (porém varia)

            // Aplica rotação em z de acordo com a aceleração em x
            transform.eulerAngles = new Vector3(0, 0, -accelerometerSmoothedValue.x * speed);
        }
    }
}
