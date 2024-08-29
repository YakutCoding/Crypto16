using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class teleksapi : MonoBehaviour
{
    public GameObject Sigma;
    public int kontoleayam;
    public TextMeshProUGUI plerekuda;
    public GameObject kontolodon,tititearno;
    bool puki;
    public adfhhuiadlfhi[] ajg;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("tititesapi",1);
        Invoke("kntlesabi",3);
    }
    void kntlesabi()
    {
        kontolodon.SetActive(false);
        puki=true;
    }
    void tititesapi()
    {
        if(puki)
        {
        kontoleayam-=1;
        }
                Invoke("tititesapi",1);
    }

    // Update is called once per frame
    void Update()
    {
       
        if(kontoleayam==0)
        {
            Destroy(kontolodon);
            foreach(adfhhuiadlfhi k in ajg)
            {
                k.enabled=true;
            }
        }
    }
}
