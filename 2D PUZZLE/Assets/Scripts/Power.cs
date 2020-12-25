using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Power : MonoBehaviour
{
   // public string CurrentLevel;
   public ParticleSystem ps;
   public GameObject Spike;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collosion)
    {
        if (collosion.gameObject.tag=="Player")
        {
            Destroy(gameObject);
            Instantiate(ps,Spike.transform.position,Quaternion.identity);
            //FindObjectOfType<AudioManager>().Play("PlayerDead");
            //UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //StartCoroutine(WaitLoadScene());
            //animation
        }
    }
    IEnumerator WaitLoadScene()
    {
        yield return new WaitForSeconds(1);
        //SceneManagement.LoadScene(CurrentLevel);
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
