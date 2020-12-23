using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float MoveSpeed=1f;
    public int ReturnAfter=1;
    Rigidbody2D rb2d;
    public bool end=true;
    public bool upDOwn=true;
    public bool What=false;
    // Start is called before the first frame update
    void Start()
    {
        rb2d=GetComponent<Rigidbody2D>();
        end=false;
        upDOwn=false;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        if(What)
        {
        if (!end)
        {
            Right();
            yield return new WaitForSeconds(ReturnAfter);
            end=true;
        }   
        else if(end)
        {
            Left();
            yield return new WaitForSeconds(ReturnAfter);
            end=false;
        }}
        else{
        if (!upDOwn)
        {
            Up();
            yield return new WaitForSeconds(ReturnAfter);
            upDOwn=true;
        }   
        else if(upDOwn)
        {
            Down();
            yield return new WaitForSeconds(ReturnAfter);
            upDOwn=false;
        }}
        
    }
    private void Right()
    {
        rb2d.velocity=new Vector2(MoveSpeed,0f);
    }
    private void Left()
    {
        rb2d.velocity=new Vector2(-MoveSpeed,0f);
    }

    private void Up()
    {
        rb2d.velocity=new Vector2(0f,MoveSpeed);
    }
    private void Down()
    {
        rb2d.velocity=new Vector2(0f,-MoveSpeed);
    }
}
