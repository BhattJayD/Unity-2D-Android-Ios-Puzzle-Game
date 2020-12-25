using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    // Start is called before the first frame update
    public void Level0()
    {
        FindObjectOfType<AudioManager>().Play("UIClick");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level0");
    }
    public void Level1()
    {
        FindObjectOfType<AudioManager>().Play("UIClick");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }
    public void Level2()
    {
        FindObjectOfType<AudioManager>().Play("UIClick");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
    }
    public void Level3()
    {
        FindObjectOfType<AudioManager>().Play("UIClick");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level");
    }
    public void Level4()
    {
        FindObjectOfType<AudioManager>().Play("UIClick");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level4");
    }
    public void Level5()
    {
        FindObjectOfType<AudioManager>().Play("UIClick");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level5");
    }
    public void Level6()
    {
        FindObjectOfType<AudioManager>().Play("UIClick");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level0");
    }
    public void Level7()
    {
        FindObjectOfType<AudioManager>().Play("UIClick");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level7");
    }
    public void Level8()
    {
        FindObjectOfType<AudioManager>().Play("UIClick");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level8");
    }
    public void Level9()
    {
        FindObjectOfType<AudioManager>().Play("UIClick");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level9");
    }
    public void Level10()
    {
        FindObjectOfType<AudioManager>().Play("UIClick");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level10");
    }
    public void Level11()
    {
        FindObjectOfType<AudioManager>().Play("UIClick");
        UnityEngine.SceneManagement.SceneManager.LoadScene("ENDLESS");
    }
}
