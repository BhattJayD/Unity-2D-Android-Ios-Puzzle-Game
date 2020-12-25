using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float speed;
    public bool canMove=false;
    public Rigidbody2D rb;

    public float maxSwipetime;
    public float minSwipeDistance;
    private float SwipeStartTime,SwipeEndTime;
    private Vector2 startSwipePosition;
    private Vector2 endSwipePosition;
    private float swipeTime,swiprLength;
    
    // Start is called before the first frame update
    void Start()
    {
        rb=gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         var velocity = rb.velocity;
       // if (canMove==true)
        //{
           /* if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                rb.velocity=new Vector2(0,1*speed*Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                rb.velocity=new Vector2(0,-1*speed*Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                rb.velocity=new Vector2(-1*speed*Time.deltaTime,0);
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                rb.velocity=new Vector2(1*speed*Time.deltaTime,0);
            }*/
            SwipeTest(); 
        //}
    }
   // void OnCollisionEnter2D(Collision2D collision)
  //  {
  //      if(collision.gameObject.tag=="wall")
    //    {
          //  canMove=true;
      //  }
//    }
    /*void OnCollisionExit2D(Collision2D collision)
    {
        canMove=false;
    }
*/
    void SwipeTest()
    {
        
        if (Input.touchCount>0)
        {
            Touch touch=Input.GetTouch(0);
            if (touch.phase==TouchPhase.Began)
            {
                SwipeStartTime=Time.time;
                startSwipePosition=touch.position;
                //canMove=true;
            }
            else if (touch.phase==TouchPhase.Ended) 
            {
                SwipeEndTime=Time.time;
                endSwipePosition=touch.position;
                swipeTime=SwipeEndTime-SwipeStartTime;
                swiprLength=(endSwipePosition-startSwipePosition).magnitude;
                if (swipeTime<maxSwipetime && swiprLength>minSwipeDistance)
                {
                    FindObjectOfType<AudioManager>().Play("PlayerMove");
                    swipeControl();
                    //canMove=true;
                }
            }
        }
    }
    void swipeControl()
    {
        Vector2 Distance=endSwipePosition-startSwipePosition;
        float xDistance=Mathf.Abs(Distance.x);
        float yDistance=Mathf.Abs(Distance.y);
        if(xDistance>yDistance)
        {
            if(Distance.x>0  )
            {
                rb.velocity=new Vector2(1*speed*Time.deltaTime,0);
               // canMove=false;
            }
            else if(Distance.x<0  )
            {
                rb.velocity=new Vector2(-1*speed*Time.deltaTime,0);
                //canMove=false;
            }
        }
        else if(yDistance>xDistance)
        {
            if(Distance.y>0 )
            {
                rb.velocity=new Vector2(0,1*speed*Time.deltaTime);
                //canMove=false;
            }
            if(Distance.y<0)
            {
                rb.velocity=new Vector2(0,-1*speed*Time.deltaTime);
                //canMove=false;
            }
        }
    }


}
