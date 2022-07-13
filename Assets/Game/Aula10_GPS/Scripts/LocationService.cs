using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LocationService : MonoBehaviour
{
    public Text locationText;

    private IEnumerator Start()
    {
        locationText.text = Input.location.status.ToString();

        // Verifica se o usuário está com o serviço de localização habilitado.
        if (!Input.location.isEnabledByUser)
            yield break;

        // Inicia o serviço de localização.
        Input.location.Start();


        // Espera até que o serviço de localização seja inicializado
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }

        // Se o serviço não inicializar em 20 segundos, o uso do serviço de localização será cancelado.
        if (maxWait < 1)
        {
            locationText.text = "O tempo expirou";
            yield break;
        }

        // Se a conexão falhar, o uso do serviço de localização será cancelado.
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            locationText.text = "Falhou";
            yield break;
        }
        else
        {
            // Se a conexão for bem-sucedida, o local atual do dispositivo será recuperado e exibido na tela.
            locationText.text = "Latitude: " + Input.location.lastData.latitude + "°\n" +
                         "Longitude: " + Input.location.lastData.longitude + "°\n" +
                         "Altitude: " + Input.location.lastData.altitude + " metros acima do mar\n" +
                         "Precisão horizontal: " + Input.location.lastData.horizontalAccuracy + " metros";
        }

        // Para o serviço de localização se não houver necessidade de consultar as atualizações de localização continuamente.
        Input.location.Stop();
    }
}
