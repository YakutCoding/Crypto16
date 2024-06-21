using System.Collections;
using System.Collections.Generic;
using UnityEngine;using Normal.Realtime;

public class plerado : MonoBehaviour
{
    public string ote;
    public string Ote{get=>ote;set=>ote=value;}
    public zkvkwa a;
    public int pusis;
    public int pusi{get=>pusis;set=>pusis=value;}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
        {
            pusi = GameObject.Find("GameController").GetComponent<GameManager>().pli;
        }
        if(pusi>0)
        {
        a.Zkvkwa =pusi;}
        if(Ote.Contains("b"))
        {
            gameObject.tag="Finish";
        }else{
            gameObject.tag="GameController";
        }
    }
}
