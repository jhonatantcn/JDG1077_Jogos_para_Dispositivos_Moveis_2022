using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFixedSlideMove : MonoBehaviour
{
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            if (t.phase == TouchPhase.Moved)
            {
                if (t.deltaPosition.y > 25)
                {
                    transform.position = Vector3.up *2;
                }

                if (t.deltaPosition.y < -25)
                {
                    transform.position = Vector3.down *2;
                }
            }
        }
    }
}
