using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI PlayerScore;

    public int PlayerScoreNum;

    public static GameManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else 
        {
            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        PlayerScoreNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerScore.text = "Score: " + PlayerScoreNum;
    }
}
