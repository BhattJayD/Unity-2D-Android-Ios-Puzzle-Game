using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndlessLevelLoad : MonoBehaviour
{
    public Animator transition;
    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.tag=="Player")
        {
            int index = Random.Range(3,15);
            //UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            StartCoroutine(LoadNextLevel(index));
        } 
    }
    IEnumerator LoadNextLevel(int levelIndex)
    {
        // play animetion
        transition.SetTrigger("Start");

        // wait
        yield return new WaitForSeconds(1);

        // load scane
        UnityEngine.SceneManagement.SceneManager.LoadScene(levelIndex);
    }
}
