using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAILEFFECTS : MonoBehaviour
{
    private float timeBtwSpawns;
    public float startTimeBtwSpawns;
    public GameObject echo;
    Rigidbody2D player;
    
    
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
         //player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        //player=GameObject.FindGameObjectsWithTag("Player");
        //player=GetComponent<Player>();
    }
    void Update()
    {
        Vector2 vel = player.velocity;
        if (vel.magnitude != 0) 
        {
            if(timeBtwSpawns<=0)
            {
                GameObject Inst=Instantiate(echo,transform.position,Quaternion.identity);
                Destroy(Inst,0.9f);
                timeBtwSpawns=startTimeBtwSpawns;
            }
            else
            {
                timeBtwSpawns-=Time.deltaTime;
            }      
        }  
    }
}
