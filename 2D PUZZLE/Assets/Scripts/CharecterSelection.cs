using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharecterSelection : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedCharacter=0;

    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter=(selectedCharacter+1)%characters.Length;
        FindObjectOfType<AudioManager>().Play("UIClick");
        characters[selectedCharacter].SetActive(true);
        
    }
    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter<0)
        {
            selectedCharacter +=characters.Length;
        }
        FindObjectOfType<AudioManager>().Play("UIClick");
        characters[selectedCharacter].SetActive(true);
    }
    // Start is called before the first frame update
    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedCharacter",selectedCharacter);
        FindObjectOfType<AudioManager>().Play("UIClick");
        //UnityEngine.SceneManagement.SceneManager.LoadScene(2,LoadSceneMode.Single);
        //UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);   
        UnityEngine.SceneManagement.SceneManager.LoadScene("LEVELSELECT");
    }
    public void QuitGame()
    {
        FindObjectOfType<AudioManager>().Play("UIClick");
        Application.Quit(); 
    }

    
}
