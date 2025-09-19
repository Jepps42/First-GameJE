using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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
        Vector2 pos  = transform.position;
        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            pos.x += Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            pos.y += Speed * Time.deltaTime;
        }
        
        transform.position = pos;

        if (Input.GetKey(KeyCode.E))
        {
            Vector2 shotHeight = new Vector2(11, 10);
            BallScript.Instance.Rigidbody.velocity = pos + shotHeight;
            BallScript.Instance.transform.SetParent(null);
            BallScript.Instance.Rigidbody.gravityScale = 1;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Bball")
        {
            BallScript.Instance.transform.SetParent(this.transform);
            BallScript.Instance.Rigidbody.gravityScale = 0;
            BallScript.Instance.Rigidbody.velocity = Vector2.zero;
        }
    }
}
