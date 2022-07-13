using UnityEngine;

public class FollowGyro : MonoBehaviour
{
    private Gyroscope gyro; // Variável do tipo Gyroscope

    private void Start()
    {
        EnableGyro();
    }

    // Ativa o giroscópio
    public void EnableGyro()
    {
        // SystemInfo: Sistema de acesso a informação de hardware
        // supportsGyroscope: Verifica se existe um giroscópio disponível no dispositivo.
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true; // Ativa o giroscópio
        }
        else
        {
            print("Este dispositivo não possui giroscópio");
        }
    }

    private void Update()
    {
        if (gyro.enabled)
        {
            // Gira o objeto de acordo com a velocidade de rotação em torno de
            // cada um dos três eixos (Euler) em radianos por segundo.
            float xRotation = -gyro.rotationRateUnbiased.x;
            float yRotation = -gyro.rotationRateUnbiased.y;
            float zRotation = gyro.rotationRateUnbiased.z;

            // O transform.eulerAngles sempre recebe a soma da velocidade de rotação
            // evitando que o objeto volte a posição inicial
            transform.eulerAngles += new Vector3(xRotation, yRotation, zRotation);
        }
    }
}