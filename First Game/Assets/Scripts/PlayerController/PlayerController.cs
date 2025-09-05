using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D RB;

    private float Speed = 8;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            vel.x = -Speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vel.y = -Speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            vel.x = Speed;
        }
        if (Input.GetKey(KeyCode.W))
        {
            vel.y = Speed;
        }
        
        RB.velocity = vel;
    }
}
