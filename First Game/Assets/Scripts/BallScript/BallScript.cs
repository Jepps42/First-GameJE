using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public GameObject Ball;

    public static BallScript Instance;

    private Vector2 Vector2 = Vector2.zero;

    private bool spawn = true;

    public Rigidbody2D Rigidbody;

    private void Awake()
    {
        Rigidbody = this.GetComponent<Rigidbody2D>();
        Ball = this.gameObject;

        if (Instance == null)
        {
            DontDestroyOnLoad(Ball);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Net")
        {
            GameManager.Instance.PlayerScoreNum++;
            this.gameObject.transform.position = Vector2;
            this.gameObject.transform.SetParent(null);
        }
    }
}
