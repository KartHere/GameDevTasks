using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public int MaxScore;
    public int CurrentScore;
    public int CurrLevel;
    public TMP_Text s;
    public GameObject LevelCompleted;
    
    // Start is called before the first frame update
    void Start()
    {
        CurrentScore = 0;
        s.text = (CurrentScore + " / " + MaxScore).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentScore == MaxScore)
            LevelPassed();
    }

    public void AddScore()
    {
        CurrentScore++;
        s.text = (CurrentScore+" / "+MaxScore).ToString();
    }
    void LevelPassed()
    {
        if (!LevelCompleted.activeSelf)
        {
            if(PlayerPrefs.GetInt("LevelPass")<(CurrLevel+1))
            PlayerPrefs.SetInt("LevelPass", CurrLevel+1);
            Time.timeScale = 0;
            LevelCompleted.SetActive(true);
        }
    }
}

