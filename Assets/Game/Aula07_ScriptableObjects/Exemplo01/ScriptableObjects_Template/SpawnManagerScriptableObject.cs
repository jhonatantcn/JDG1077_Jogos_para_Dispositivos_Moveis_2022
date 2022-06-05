using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject")]
public class SpawnManagerScriptableObject : ScriptableObject
{
    public string prefixName;

    public int numberOfPrefabsToCreate;
    public Vector3[] spawnPoints;
}