using System.Collections;
using System.Collections.Generic;
using UnityEngine;using Normal.Realtime;

public class pntilkda : MonoBehaviour
{
    public Transform pli;
    public string obj;
    public RealtimeView r;
    public bool puesu;
    // Start is called before the first frame update
    void OnEnable()
    {if(r.isOwnedLocallyInHierarchy)
    {
        
        GameObject a = Realtime.Instantiate(obj,pli.transform.position,pli.transform.rotation);
        if(puesu)
        {GameObject[] p = GameObject.FindGameObjectsWithTag("Player");
            foreach(GameObject b in p)
            {
                if(b.GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
                {
                    a.GetComponent<plerado>().Ote = b.GetComponent<cakv>().Cakvs;
                }
            }
        }
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
