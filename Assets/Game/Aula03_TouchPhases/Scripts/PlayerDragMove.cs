using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDragMove : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            if (t.phase == TouchPhase.Moved)
            {
                transform.position += (Vector3)t.deltaPosition / 300; // Dividido por 300 para deixar a movimentação do player mais lenta
            }
        }
    }
}
