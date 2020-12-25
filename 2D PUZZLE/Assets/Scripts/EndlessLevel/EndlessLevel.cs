using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessLevel : MonoBehaviour
{
    public GameObject[] Spown;
    public GameObject[] POINT;
    //public Transform spawnPoint;
    private int randomSpot;
    // Start is called before the first frame update
    void Start()
    {
        randomSpot=Random.Range(0,Spown.Length);
        int selectedCharacter=PlayerPrefs.GetInt("selectedCharacter");
        GameObject prefab=Spown[selectedCharacter];
        //GameObject prefab=Spown[randomSpot];
        GameObject clone=Instantiate(prefab,POINT[randomSpot].transform.position,Quaternion.identity);
        clone.SetActive(true);
        //transform.position=Vector2.MoveTowards(transform.position,moveSpot[randomSpot].position,speed*Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
