using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hint : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public float time = 5;
    string sen="SO YOU ARE STUCK HERE! CAN YOU FIND SOLUTION TO THE NEXT LEVEL";
    //string[] arr=new string[]{sen};

    // Start is called before the first frame update
    void Start()
    {
        textDisplay.text=sen;
        StartCoroutine(DELETE());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator  DELETE()
    {
        yield return new WaitForSeconds(10);
        Destroy(textDisplay.gameObject);
    }

}
