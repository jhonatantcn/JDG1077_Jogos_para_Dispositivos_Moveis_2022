using UnityEngine;

public class Spawner : MonoBehaviour
{
    // O GameObject a ser instanciado.
    public GameObject entityToSpawn;

    // Uma instância do ScriptableObject definido acima.
    public SpawnManagerScriptableObject spawnManagerValues;

    // Isso será anexado ao nome das entidades criadas e incrementado quando cada uma for criada.
    int instanceNumber = 1;

    void Start()
    {
        SpawnEntities();
    }

    void SpawnEntities()
    {
        // Controle de locais para aparecer
        int currentSpawnPointIndex = 0;

        for (int i = 0; i < spawnManagerValues.numberOfPrefabsToCreate; i++)
        {
            // Cria uma instância do prefab no spawn point atual.
            GameObject currentEntity = Instantiate(entityToSpawn, spawnManagerValues.spawnPoints[currentSpawnPointIndex], Quaternion.identity);

            // Define o nome da entidade instanciada para ser a string definida no ScriptableObject e, em seguida, acrescenta um número exclusivo. 
            currentEntity.name = spawnManagerValues.prefixName + instanceNumber;

            // Move para o próximo índice de spawn point. Se ficar fora do alcance, volta ao início.
            currentSpawnPointIndex = (currentSpawnPointIndex + 1) % spawnManagerValues.spawnPoints.Length;

            instanceNumber++;
        }
    }
}