using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackgroundColor : MonoBehaviour
{
    private SpriteRenderer sr;
    bool isrunning=false;
    public Color[] cbook={ new Color(172,25,78,255), new Color(172,75,28,255), new Color(106,44,112,255), new Color(149,255,211,255),  new Color(144,55,73,255), new Color(246, 65, 108, 255),new Color(13, 115, 119, 255),new Color(255, 189, 57, 255)};
    int num=0;
    // Start is called before the first frame update
    void Start()
    {
        num=Random.Range(0,cbook.Length);
        sr=GetComponent<SpriteRenderer>();
 
    }

    // Update is called once per frame
    void Update()
    {
        if(sr!=null)
        {
            if(isrunning==false)
            {
                
                isrunning=true;
                StartCoroutine(changeColor());
            }
        }
        
    }
    IEnumerator changeColor()
    {
        //Change Random Color every 5 sec
        
        //Color c=new Color(Random.value,Random.value,Random.value);
        //sr.color=c;

        //Change List of color

        num=Random.Range(0,cbook.Length);
        sr.color=cbook[num];
        yield return new WaitForSeconds(15);
        isrunning=false;

    }
}
