using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform spawnPoint;
    //public Transform spawnPoint1;

void OnCollisionEnter2D(Collision2D collision2D)
    {
        //If the object we collided with was an Asteroid.
        if (collision2D.transform.tag == "Player")
        {
          
        collision2D.gameObject.transform.position=spawnPoint.position;
        Debug.Log("#######################################################S");
    }
    }
}
