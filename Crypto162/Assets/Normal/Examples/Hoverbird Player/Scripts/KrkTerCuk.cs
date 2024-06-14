using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
public class KrkTerCuk : MonoBehaviour
{
    public int cuk;
    public int Cuk{get=>cuk;set=>cuk=value;}
    public GameObject[] supriadi;
    public RealtimeView r;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject a in supriadi)
        {
            a.SetActive(false);
        }
        Invoke("pentil",1);
    }
    void pentil()
    {
         foreach(GameObject a in supriadi)
        {
            a.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
if(r.isOwnedLocallyInHierarchy)
{
    Cuk= PlayerPrefs.GetInt("hro");
}
supriadi[Cuk].SetActive(true);
    }
}
