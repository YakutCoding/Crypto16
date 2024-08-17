using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class asofjasof : MonoBehaviour
{
    public Button[] s;
    public GameObject a;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("daifj")==0)
        {
            a.SetActive(true);
           
        }
        foreach(Button add in s)
        {
            add.onClick.AddListener(sd);
        }
    }
    public void sd()
    {
        PlayerPrefs.SetInt("daifj",1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
