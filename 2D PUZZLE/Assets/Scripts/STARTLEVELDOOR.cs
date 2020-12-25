using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class STARTLEVELDOOR : MonoBehaviour
{
    public GameObject fin;
  void OnCollisionEnter2D(Collision2D collision2D)
    {
        //If the object we collided with was an Asteroid.
        
        //GameObject go = GameObject.FindGameObjectWithTag ("Finish");
        if(fin.activeInHierarchy == false)
        {
        fin.SetActive (true);
        Destroy (gameObject);
        }  
        //other.gameObject.transform.position=spawnPoint1.position;
        
    }
}
