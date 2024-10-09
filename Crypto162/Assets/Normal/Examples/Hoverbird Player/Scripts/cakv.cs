using System.Collections;
using System.Collections.Generic;
using UnityEngine;using Normal.Realtime;
using TMPro;using UnityEngine.SceneManagement;
public class cakv : MonoBehaviour
{ public string cakvs;
    public string Cakvs {get=>cakvs;set=>cakvs=value;}
    public Outline[] pentilbabi;
    public TextMeshProUGUI t;
    public GameObject asgu;
    public GameObject[] puentol;
    public Color plsd;

    public PlayerCount p;
    void Update()
    {
        p=GameObject.Find("PlayerCount").GetComponent<PlayerCount>();
        if(Cakvs.Length<1&&GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
        {
            if(!p.AvaibleToWithdraw)
            {
                SceneManager.LoadScene("Full");
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.name.Contains("xkdrk"))
        {
        Cakvs = other.name;
        
        }
        if(Cakvs!="")
        {
            if(Cakvs.Contains("b"))
        {
            foreach(Outline ps in pentilbabi)
            {
            ps.OutlineColor = plsd;
            t.color=Color.cyan;
            foreach(GameObject puentols in puentol)
            {
            puentols.tag = "Finish";
            }
            }
        }
        else{
             foreach(Outline ps in pentilbabi)
            {
            ps.OutlineColor = Color.red;
              t.color=Color.red;
                   foreach(GameObject puentols in puentol)
            {
               puentols.tag = "GameController";}
            }
        }
        }else{
            
        }
        
    }

}
