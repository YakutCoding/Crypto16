using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;using TMPro;using Normal.Realtime;
public class takpct : MonoBehaviour
{
    public int takpctt;
    public int Takpcts{get=>takpctt;set=>takpctt=value;}
    public int mxtk;
    public cakv a;
    public TextMeshProUGUI puky;
    public Image sasds;
    public Animator GameUtility;
    GameObject usi;
    /* Wkkwkwkwk hack terus bang, nanti dibanned nangis.. kita bisa dapetin ip lu dengan ez, jadinya lu gabisa kerjain airdrop lagi walau bikin akun baru.*/
    void Start()
    {
        mxtk = Takpcts;
    }
    void setSensitivity(){
  
                      if(a.Cakvs.Contains("xkdrk"))
        {
            if(a.Cakvs.Contains("b"))
            {
                if(usi.tag == "GameController")
                {
                 
                  Takpcts-= usi.GetComponent<zkvkwa>().Zkvkwa;
                    GameObject GameCoin = Realtime.Instantiate("GameCoin",gameObject.transform.position,gameObject.transform.rotation);
                    GameCoin.GetComponent<cqczvl>().kntl = ""+usi.GetComponent<zkvkwa>().Zkvkwa;
                    GameCoin.GetComponent<cqczvl>().kolor=gameObject;
                }
            }else{
if(usi.tag == "Finish")
                {
                    Takpcts-= usi.GetComponent<zkvkwa>().Zkvkwa;
                    GameObject GameCoin = Realtime.Instantiate("GameCoin",gameObject.transform.position,gameObject.transform.rotation);
                    GameCoin.GetComponent<cqczvl>().kntl = ""+usi.GetComponent<zkvkwa>().Zkvkwa;
                    GameCoin.GetComponent<cqczvl>().kolor=gameObject;
                }
            }}
                
    }
    void Update()
    {
        sasds.fillAmount = ((float)Takpcts/(float)mxtk);
        puky.text = ""+Takpcts;
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<NewBehaviourScript>()!=null)
        {
                GameUtility.Play("GameUtility");
        }
        if(GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
        {
            Invoke("setSensitivity",0.5f);
                    usi = other.gameObject;
      
        }
    }
}
