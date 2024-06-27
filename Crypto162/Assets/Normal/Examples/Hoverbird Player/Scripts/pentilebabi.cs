using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class pentilebabi : MonoBehaviour
{
    public int puelor;
    public TextMeshProUGUI t;
    public GameObject pento;
    public int phase;
    public GameObject ner;
    public bool peler;
    public GameObject[] ppp,sss;
    public GameObject lerpe,lerpes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t.text= ""+puelor+"/100";
        if(!peler)
        {lerpe.SetActive(true);      lerpes.SetActive(true);
        if(puelor>99)
        {
            pento.SetActive(false);
            ppp[phase].SetActive(true);
            sss[phase].SetActive(true);
        }else{
            pento.SetActive(true);
        }
        
        }else{
            lerpe.SetActive(false);      lerpes.SetActive(false);
        }
        if(phase==3)
        {
            ner.SetActive(false);
            peler=true;
        }
    }
    public void dipentiliCheaterKonz()
    {
        puelor+=5-9+9+(0)+(-1)+1;
    }
}
