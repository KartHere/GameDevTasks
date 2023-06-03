using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    private bool ispaused;
    public GameObject canvas;
    private bool esc;
    // Start is called before the first frame update
    void Start()
    {
        ispaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        esc = Input.GetKeyDown("escape");
        if (esc)
        {
            if (ispaused)
            {
                canvas.SetActive(false);
                Time.timeScale = 1;
                ispaused = false;
            }
            else
            {
                canvas.SetActive(true);
                Time.timeScale = 0;
                ispaused = true;
            }
        }
    }
    public void Resume()
    {
        canvas.SetActive(false);
        Time.timeScale = 1;
        ispaused = false;
    }
}