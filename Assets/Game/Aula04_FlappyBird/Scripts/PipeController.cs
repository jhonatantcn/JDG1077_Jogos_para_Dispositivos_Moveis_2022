using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    public GameObject player;
    public List<GameObject> pipesList;

    public float playerPipeDistance;
    public float spawnPipeDistance;


    void Update()
    {
        if(player.transform.position.x - pipesList[0].transform.position.x > playerPipeDistance)
        {
            int rand = Random.Range(-3, 3);
            pipesList[0].transform.position = new Vector2(pipesList[0].transform.position.x + spawnPipeDistance, rand);
        }

        if(player.transform.position.x - pipesList[1].transform.position.x > playerPipeDistance)
        {
            int rand = Random.Range(-3, 3);
            pipesList[1].transform.position = new Vector2(pipesList[1].transform.position.x + spawnPipeDistance, rand);
        }

        if(player.transform.position.x - pipesList[2].transform.position.x > playerPipeDistance)
        {
            int rand = Random.Range(-3, 3);
            pipesList[2].transform.position = new Vector2(pipesList[2].transform.position.x + spawnPipeDistance, rand);
        }
    }
}
