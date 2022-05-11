using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInstantMove : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            Vector3 pos = Camera.main.ScreenToWorldPoint(t.position);
            pos.z = 0;

            transform.position = pos;

        }
    }
}
