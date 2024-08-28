using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;using TMPro;using Normal.Realtime;using UnityEngine.SceneManagement;
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
    bool coinGet;
    int MovementPoint;
    GameObject obj;
    
    /* Wkkwkwkwk hack terus bang, nanti dibanned nangis.*/
    void GetCoin()
    {//GetCoin from Database
        if(GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
        {
        if(coinGet)
        {
            Takpcts-=10;
            GameObject GameCoin = Realtime.Instantiate("GameCoins",gameObject.transform.position,gameObject.transform.rotation);
            GameCoin.GetComponent<cqczvl>().kntl = ""+10;
             GameCoin.GetComponent<cqczvl>().kolor=gameObject;
             coinGet=false;GameUtility.Play("GameUtility");
        }}
        Invoke("GetCoin",0.5f);
    }
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
        if(Takpcts>499)
        {
            Realtime.Destroy(gameObject);
            Destroy(gameObject);
        }
        sasds.fillAmount = ((float)Takpcts/(float)mxtk);
        puky.text = ""+Takpcts;
        if(GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
        {
        if(Takpcts<1)
        {
            
            Invoke("Hey",6);
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
               
            
            MovementPoint=Takpcts;
        }
    }}
   
    } 
    
    void OnTriggerStay(Collider other)
    {
        if(other.tag=="GameCoin")
        {
            coinGet=true;
        }
    }
   public void jkl(){
    int sdff=Random.Range(8,13);
        Takpcts-=sdff;
                    GameObject GameCoin = Realtime.Instantiate("GameCoin",gameObject.transform.position,gameObject.transform.rotation);
                    GameCoin.GetComponent<cqczvl>().kntl = ""+sdff;
                    GameCoin.GetComponent<cqczvl>().kolor=gameObject;
    }    void Hey()
    {
            
              if(a.Cakvs.Length>0)
                {
                       if(a.Cakvs.Contains("b"))
            {
gameObject.transform.position = new Vector3(Random.Range(-12,12),9,Random.Range(30,86));
Debug.Log("asd");
            }else
            {
                gameObject.transform.position = new Vector3(Random.Range(-12,12),9,Random.Range(-86,-30));Debug.Log("kntol");
            }
            }if(GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
            {
            Invoke("pentoll",1);
            Realtime.Instantiate("urip",gameObject.transform.position,gameObject.transform.rotation);}
            
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
        
        void CheckMovementPoint()
        {
            if(Takpcts>MovementPoint)
            {
                MovementPoint = Takpcts;
                Invoke("CheckJump",1f);
                PlayerPrefs.SetInt("SEND DATA TO SERVER",1);
                print("sUPRI1");
            }


        }
        void CheckJump()
        {
 if(Takpcts>MovementPoint)
            {
                MovementPoint = Takpcts;
                Invoke("CheckRunAvaibility",1f);
                PlayerPrefs.SetInt("SEND DATA TO SERVER",1);
                print("sUPRI2");
            }
        }
        void CheckRunAvaibility()
        {
             if(Takpcts>MovementPoint)
            {
                 MovementPoint = Takpcts;
                Realtime.Destroy(gameObject);
                Destroy(gameObject);SceneManager.LoadScene("Lag");
                //DONT SEND TO SERVER DATA POSITION.SceneManager.LoadScene("Lag");
                print("sUPRI4");
            }
        }


    public void OnTriggerEnter(Collider other)
    {

      if(other.GetComponent<zkvkwa>()!=null)
            {
                Invoke("pentol",0.8f); obj=other.gameObject;
            }
        if(other.GetComponent<NewBehaviourScript>()!=null)
        {
                GameUtility.Play("GameUtility");
        }
        if(GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
        {
            Invoke("setSensitivity",0.4f);if(other.GetComponent<zkvkwa>()!=null || other.tag=="GameCoin")
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
    void pentol()
    {
      
        if(obj.tag!="GameCoin")
        {  Invoke("CheckMovementPoint",1.2f);
                MovementPoint-=obj.GetComponent<zkvkwa>().Zkvkwa;
        }
    }
}
