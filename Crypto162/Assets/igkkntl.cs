using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class igkkntl : MonoBehaviour
{
    public GameObject[] a;
    public GameObject[] nona;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("kntl")==1)
        {
            PlayerPrefs.SetInt("kntl",0);
            foreach(GameObject sup in a)
            {
                sup.SetActive(true);
            }
            foreach(GameObject zi in nona){
                zi.SetActive(false);
            }
        }
    }
}
