using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI PlayerScore;

    public int PlayerScoreNum;

    public static GameManager Instance;

    public TextMeshProUGUI TimerText;

    //public TextMeshProUGUI YouLose;


    public float Timer = 60;

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
    private void Start()
    {
        PlayerScoreNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerScore.text = "Score: " + PlayerScoreNum;

        TimerText.text = "Time: " + (Mathf.Floor(Timer*10)/10);

        //YouLose.text = "Congrats, your score was: " + PlayerScoreNum;

        Timer -= Time.deltaTime;
        if (Timer <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
