using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public ObjectPool objectPool;
    private Touch t;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            t = Input.GetTouch(0);

            if (t.phase == TouchPhase.Began)
            {
                for (int i = 0; i < objectPool.amountToPool; i++)
                {
                    if (!objectPool.pooledObjects[i].activeInHierarchy)
                    {
                        objectPool.pooledObjects[i].SetActive(true);
                        objectPool.pooledObjects[i].GetComponent<Rigidbody2D>().velocity = new Vector2(0, 2);
                        break;
                    }
                }
            }
        }

        for (int i = 0; i < objectPool.amountToPool; i++)
        {
            if (objectPool.pooledObjects[i].activeInHierarchy && objectPool.pooledObjects[i].transform.position.y > 7)
            {
                objectPool.pooledObjects[i].transform.position = new Vector2(0, -2); // posição inicial
                objectPool.pooledObjects[i].SetActive(false);
            }
        }
    }
}
