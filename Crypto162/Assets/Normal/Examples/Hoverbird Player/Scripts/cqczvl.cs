using System.Collections;
using System.Collections.Generic;
using UnityEngine;using TMPro;

public class cqczvl : MonoBehaviour
{
    public TextMeshProUGUI t;
    public string pler;
    public string kntl{get=>pler;set=>pler=value;}
    public GameObject kolor;
    // Start is called before the first frame update
    void Start()
    {
        if(kntl.Length>0)
        {
        gameObject.name = kntl;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(kntl.Length>0)
        {
        gameObject.name = kntl;
        }
        if(kntl.Length>0)
        {
        t.text = gameObject.name;
        }
        if(kolor!=null)
        {
            gameObject.transform.position = new Vector3(kolor.transform.position.x,kolor.transform.position.y,kolor.transform.position.z);
        }
    }
}
