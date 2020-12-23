using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    private float waitTime;
    public float StartWaitTime;

    public Transform moveSpot;
    public float minX,maxX,minY,maxY;

    public float timeBtwShots;
    public float startTimeBtwShots;
    public GameObject Projectile;

    // Start is called before the first frame update
    void Start()
    {
        waitTime=StartWaitTime;
        timeBtwShots=startTimeBtwShots;
        moveSpot.position=new Vector2(Random.Range(minX,maxX),Random.Range(minY,maxY));
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Vector2.MoveTowards(transform.position,moveSpot.position,speed*Time.deltaTime);
        if(Vector2.Distance(transform.position,moveSpot.position)<0.2f)
        {
            if(waitTime <=0)
            {
                moveSpot.position=new Vector2(Random.Range(minX,maxX),Random.Range(minY,maxY));
                waitTime=StartWaitTime;
            }
            else
            {
                waitTime-=Time.deltaTime;
            }
        }
        if(timeBtwShots<=0)
        {
            GameObject inst= Instantiate(Projectile,transform.position,Quaternion.identity);
            timeBtwShots=startTimeBtwShots;
            Destroy(inst,3f);
        }
        else
        {
            timeBtwShots-=Time.deltaTime;
            
        }
    }
}
