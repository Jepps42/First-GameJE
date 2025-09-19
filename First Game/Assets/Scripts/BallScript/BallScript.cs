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

    public bool ThreePointRange;

    public float ThreePointer = 1;
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
        //Write a code that checks if the ball is in range for 3-pointer
        
        
        //Write a code that gives the player 3 points if the ball was shot in 3-point range
        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Net")
        {
            GameManager.Instance.PlayerScoreNum += 2;
            this.gameObject.transform.position = Vector2;
            this.gameObject.transform.SetParent(null);

            if (ThreePointRange == true)
            {
                
                GameManager.Instance.PlayerScoreNum += 3;
            }
            
        }
    }
}
