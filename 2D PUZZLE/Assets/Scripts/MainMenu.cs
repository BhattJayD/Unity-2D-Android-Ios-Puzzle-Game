using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        //UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        FindObjectOfType<AudioManager>().Play("UIClick");
        UnityEngine.SceneManagement.SceneManager.LoadScene("CharacterSelect");
    }
    public void QuitGame()
    {
        FindObjectOfType<AudioManager>().Play("UIClick");
        Application.Quit(); 
    }
}
