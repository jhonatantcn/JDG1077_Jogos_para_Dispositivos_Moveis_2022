using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    [Range(0f, 1000f)]public float speed;
    [Range(0f, 1000f)]public float jumpForce;
    private Touch t;

    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);


        if(Input.touchCount > 0)
        {
            t = Input.GetTouch(0);
            
            if(t.phase == TouchPhase.Began)
            {
                rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
            }
        }

    }
}
