using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Projectile : MonoBehaviour
{
    public float speed=2f;
    public ParticleSystem ps;
    public Transform player;
    public Vector2 target;
    // Start is called before the first frame update
    void Start()
    {
        if(GameObject.FindGameObjectWithTag("Player")!=null)
        {
            player=GameObject.FindGameObjectWithTag("Player").transform;
            target=new Vector2(player.position.x,player.position.y);
        }
        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            StartCoroutine(WaitLoadScene());
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Vector2.MoveTowards(transform.position,target,speed*Time.deltaTime);
        if(transform.position.x==target.x && transform.position.y==target.y)
        {
         //   DistroyProjectile();
         
        Instantiate(ps,transform.position,Quaternion.identity);
        Destroy(gameObject);
        }
        if(GameObject.FindGameObjectWithTag("Player")==null)
        {
            
            StartCoroutine(WaitLoadScene());
            UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
        }
    }
    /*void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Instantiate(ps,other.transform.position,Quaternion.identity);
            StartCoroutine(DELETEproj());
            
             
        }   
    }

*/
    private void OnCollisionEnter2D(Collision2D collosion)
    {
        if (collosion.gameObject.tag=="Player")
        {
            Destroy(collosion.gameObject);
            FindObjectOfType<AudioManager>().Play("PlayerDead");
            StartCoroutine(WaitLoadScene());
            Instantiate(ps,transform.position,Quaternion.identity);            
            //UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            
            //animation
        }
    }
    IEnumerator WaitLoadScene()
    {
        
        yield return new WaitForSeconds(1);
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //SceneManagement.LoadScene(CurrentLevel);
        

    }
    void DistroyProjectile()
    {
        Instantiate(ps,transform.position,Quaternion.identity);
        Destroy(gameObject);
    }
    IEnumerator DELETEproj()
    {
        yield return new WaitForSeconds(1);
        //SceneManagement.LoadScene(CurrentLevel);
        UnityEngine.SceneManagement.SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
