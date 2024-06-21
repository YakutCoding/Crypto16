using System.Collections;
using System.Collections.Generic;
using UnityEngine;using Normal.Realtime;

public class pintu : MonoBehaviour
{

    public int pla,pli,plo,kec;
    public pentilebabi p;
    public GameObject gg;
    public GameManager g;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void kntol()
    {
g.pler +=pla;
g.pli+=pli;
g.kepalasekolah+=kec;
g.plo+= plo;
Invoke("pentileEnak",0.5f);gg.GetComponent<Animator>().Play("animo")
;p.puelor=0;
p.phase++;
GameObject[] su = GameObject.FindGameObjectsWithTag("Player");
foreach(GameObject sa in su)
{//Set Movement velocity more mooth
    if(sa.tag == "Player")
    {
        if(sa.GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
        {
            sa.GetComponent<takpct>().Takpcts= g.plo;
        }
    }
}
    }

    // Update is called once per frame
    void pentileEnak()
    {
     gg.SetActive(false);
    }
}
