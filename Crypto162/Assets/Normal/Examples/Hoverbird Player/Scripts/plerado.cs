using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plerado : MonoBehaviour
{
    public string ote;
    public string Ote{get=>ote;set=>ote=value;}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Ote.Contains("b"))
        {
            gameObject.tag="Finish";
        }else{
            gameObject.tag="GameController";
        }
    }
}
