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
    public Animator GameUtility,bapak;
    GameObject usi;
    public HoverbirdPlayer p;
    public GameObject coin,coinr;
    public int[] plerados;
    public KrkTerCuk asd;
    
    /* Wkkwkwkwk hack terus bang, nanti dibanned nangis.. kita bisa dapetin ip lu dengan ez, jadinya lu gabisa kerjain airdrop lagi walau bikin akun baru.*/
    void Start()
    {
        Invoke("CoinDrop",1);
    }
    void CoinDrop()
    {
        Takpcts = plerados[asd.Cuk];
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
        if(Takpcts<1)
        {Invoke("Hey",6);
         if(a.Cakvs.Contains("xkdrk"))
        {
            if(a.Cakvs.Contains("b"))
            {
            
                 Realtime.Instantiate(coinr.name,gameObject.transform.position,gameObject.transform.rotation);
                
            }else{

                Realtime.Instantiate(coin.name,gameObject.transform.position,gameObject.transform.rotation);
                
            }}
            if(GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
            {
                
                gameObject.transform.position = new Vector3(gameObject.transform.position.x,-900,gameObject.transform.position.z);
                Takpcts=mxtk;
              
            GameObject s = GameObject.Find("GameController");
            s.GetComponent<GameManager>().skibidisigma.SetActive(true);
               
            
            
        }
    }
   
    } void Hey()
    {
            
              if(a.Cakvs.Length>0)
                {
                       if(a.Cakvs.Contains("b"))
            {
gameObject.transform.position = new Vector3(Random.Range(-90,90),9,Random.Range(30,86));
Debug.Log("asd");
            }else
            {
                gameObject.transform.position = new Vector3(Random.Range(-90,90),9,Random.Range(-86,-30));Debug.Log("kntol");
            }
            }
            Invoke("pentoll",1);
            Realtime.Instantiate("urip",gameObject.transform.position,gameObject.transform.rotation);
            
            }
            void pentoll()
            {
                   GameObject s = GameObject.Find("GameController");
            s.GetComponent<GameManager>().skibidisigma.SetActive(false); 
            }
        void pntil()
        {
            p.sl=1;
        }
    void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<NewBehaviourScript>()!=null)
        {
                GameUtility.Play("GameUtility");
        }
        if(GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
        {
            Invoke("setSensitivity",0.4f);if(other.GetComponent<zkvkwa>()!=null)
            {
                GameUtility.Play("GameUtility");
            }
                    usi = other.gameObject;
      
        }
         if(!other.GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
            {
            if(other. GetComponent<NewBehaviourScript>()!=null)
            {
                if((other.GetComponent<plerado>().Ote != GetComponent<cakv>().Cakvs) && other.GetComponent<plerado>().Ote.Length>0)
                {
                p.sl=0;
                Invoke("pntil",other.GetComponent<NewBehaviourScript>().GameTime);
                }
            }
            
            }
            if(other.GetComponent<NewBehaviourScript>()!=null)
            {          if((other.GetComponent<plerado>().Ote != GetComponent<cakv>().Cakvs) && other.GetComponent<plerado>().Ote.Length>0)
                {
                bapak.Play("stun");
                }
            }
    }
}
