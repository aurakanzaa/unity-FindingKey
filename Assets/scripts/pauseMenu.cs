using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour {

    public GameObject Panel;

    private bool paused = false;

    void Start()
    {
        Panel.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            paused = !paused;
        }
        if (paused)
        {
            Debug.Log("dsad");
            Panel.SetActive(true);
            Time.timeScale = 0;
        }
        if (!paused)
        {
            Panel.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void Resume()
    {
        //Debug.Log("resume");
        //paused = false;
        Application.LoadLevel(1);
    }
}
