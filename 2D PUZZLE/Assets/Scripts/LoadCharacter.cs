using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LoadCharacter : MonoBehaviour
{
    public GameObject[] CharacterPrefabs;
    public Transform spawnPoint;
   // public TMP_Text label;
    // Start is called before the first frame update
    void Start()
    {
        int selectedCharacter=PlayerPrefs.GetInt("selectedCharacter");
        
        GameObject prefab=CharacterPrefabs[selectedCharacter];
        
        GameObject clone=Instantiate(prefab,spawnPoint.position,Quaternion.identity);
        
        clone.SetActive(true);
    //    label.text=prefab.name;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
