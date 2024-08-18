using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using TMPro;
public class jkasfd : MonoBehaviour
{
    public int asj;
    public bool jdsk,jdj;
    public TextMeshProUGUI T;
    public GameObject asjd,asjg,akjd,KTNL;
    public pentilebabi p;
    // Start is called before the first frame update
    void Start()
    {
        if(jdj)
        {
        Invoke("sui",21);
        }
    }
void sui()
{
    jdsk=true;
    asjd.SetActive(true);

}
    // Update is called once per frame
    void Update()
    {
        if(jdsk)
        {
            T.text = ""+asj+"/10";
            if(asj==10)
            {
                Destroy(asjd);
                asjg.SetActive(true); p.peler=false;
                akjd.SetActive(true);KTNL.SetActive(true);
               
            }
        }
    }
    void OnTriggerEnter(Collider ot)
    {if(jdsk){asj++;}
       
          gameObject.GetComponent<Animator>().Play("Sdj");
        GameObject r= Realtime.Instantiate("GameCoins",gameObject.transform.position,gameObject.transform.rotation);
        r.GetComponent<cqczvl>().kntl = ot.GetComponent<zkvkwa>().Zkvkwa.ToString();
    }
}
