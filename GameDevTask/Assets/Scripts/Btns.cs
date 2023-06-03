using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Btns : MonoBehaviour
{
    public int LevelNum;
    private int LastLevel;
    // Start is called before the first frame update
    void Start()
    {
        LastLevel = 5;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
    public void LoadLevel()
    {
        int LevelPass = PlayerPrefs.GetInt("LevelPass", 1);
        Debug.Log(LevelPass);
        if (LevelNum <=LevelPass&& LevelNum <= LastLevel)
        {
            SceneManager.LoadScene("Level" + LevelNum);
            Time.timeScale = 1;
        }
    }
    public void QuitGame()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}

