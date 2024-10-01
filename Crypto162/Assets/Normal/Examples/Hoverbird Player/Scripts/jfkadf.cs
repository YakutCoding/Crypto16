using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
public class jfkadf : MonoBehaviour
{
    public string a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            GameObject[] pl = GameObject.FindGameObjectsWithTag("Player");
             foreach(GameObject ass in pl)
            {
                if(ass.GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
            {
                if(ass.GetComponent<cakv>().Cakvs.Contains("b"))
                {
                 a="xkdrkb";
                }else{
a="xkdrk";
                }
            }
            }
                    foreach(GameObject ass in pl)
            {
                if(!ass.GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
            {
                if(ass.GetComponent<cakv>().Cakvs !=a)
                {
                 ass.GetComponent<cakv>().asgu.SetActive(true);
                }else{
  ass.GetComponent<cakv>().asgu.SetActive(false);
                }
            }
            }
    }
    }

