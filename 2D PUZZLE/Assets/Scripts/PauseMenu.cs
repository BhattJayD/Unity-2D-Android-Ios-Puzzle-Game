using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPause=false;
    public GameObject pauseMenuUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    /*void Update()
    {
        if (GameIsPause)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }*/
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale=1f;
        GameIsPause=false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale=0.0009f;
        GameIsPause=true;
    }
    public void Menu()
    {
        Time.timeScale=1f;
        GameIsPause=false;
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
    public void QuitGame()
    {
        Application.Quit(); 
    }
}
