using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;using Dan.Demo;
using UnityEngine.SceneManagement;using Normal.Realtime;
public class PlayerCount : MonoBehaviour
{
    public int asdf;
    public TextMeshProUGUI dpn,aseli,bl,rd,bld,rdd,pl,lks;
    public cakv[] b,r;
    public int Asdf{get=>asdf;set=>asdf=value;}
    public GameObject pentil,rb,bb,misi,uicount,COLSAIDJSAI,camo,coma,cami,at,ut,pentol,pentileayam,pentilesapi,peju,sigma;
    public ParticleSystem bbb,rrr;
    public pentilebabi tetaelek;
    public bool AvaibleToWithdraw=true;
    bool Plor,sfkd;
    public peliKambing pel;    public LeaderboardShowcase l;
    bool bokep;
    // Start is called before the first frame update
    void Start()
    {sfkd=false;
        Application.targetFrameRate = 90;
        Invoke("Pentil",0.3f);
        Invoke("pler",1f);Invoke("bkp",1f);
    }
    void Pentil()
    {
      
        if(Asdf<0|| b.Length+r.Length>6)
        {
            SceneManager.LoadScene("Full");
        }
        
    }
    void bkp()
    {
        bokep=true;
    }
void susu()
{
    pentol.SetActive(true);
}
    // Update is called once per frame
    void Update()
    {
        if(Plor)
        {
            Asdf=-1; 
        }
      
        // Mencari semua game object dengan script Cakv
        GameObject[] allCakvs = GameObject.FindGameObjectsWithTag("Player");

        // List sementara untuk menyimpan Cakv dengan Cakvs = "xkdrkr" dan "xkdrkb"
        var tempListR = new List<cakv>();
        var tempListB = new List<cakv>();

        // Memasukkan game object ke dalam list sementara r dan b
        foreach (GameObject obj in allCakvs)
        {
            cakv cakvScript = obj.GetComponent<cakv>();
            if (cakvScript != null)
            {
                if (cakvScript.Cakvs == "xkdrkr")
                {
                    tempListR.Add(cakvScript);
                }
                else if (cakvScript.Cakvs == "xkdrkb")
                {
                    tempListB.Add(cakvScript);
                }
            }
        }
        foreach(GameObject obj in allCakvs)
        {
            if(obj.GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
            {
                if(obj.GetComponent<cakv>().Cakvs.Length>0)
                {
                if(obj.GetComponent<cakv>().Cakvs.Contains("b"))
                {
                pl.text="Team Selected : Blue";
                }else{
                    pl.text = "Team Selected : Red";
                }}
            }
        }
        Debug.Log("tempListB"+tempListB.ToArray().Length);
          Debug.Log("tempListE"+tempListR.ToArray().Length);
          if(AvaibleToWithdraw)
          {
          if(tempListB.ToArray().Length>1 && tempListR.ToArray().Length>1){
          pel.elss =6;
          }else{
            pel.elss=1;
          }}
          if(pel.elss<3){lks.text= lks.text.Replace("f","<color=red>"+(pel.elss+1).ToString())+"</color>";}else{ lks.text= lks.text.Replace("f",(pel.elss+1).ToString());}
        if(pel.elss<3)
        {
            sigma.SetActive(true);
        }else{
            sigma.SetActive(false);
        }
        // Mengkonversi list sementara ke dalam array r dan b
        r = tempListR.ToArray();
        b = tempListB.ToArray();
        if(r.Length>2)
        {
            rb.SetActive(true);
            
        }else{
            rb.SetActive(false);
        }
        if(b.Length>2)
        {
            bb.SetActive(true);
        }else{
            bb.SetActive(false);
        }

        if(SimpleInput.GetButtonDown("Red")||SimpleInput.GetButtonDown("Blue"))
        {
            pentil.SetActive(true);
            Destroy(camo,1.5f);
        }
        if(Asdf<0)
        {cami.SetActive(true);
        coma.SetActive(true);
            misi.SetActive(true);
            Invoke("susu",5f);
    uicount.SetActive(false);
    bbb.loop=false;
    rrr.loop=false;
    COLSAIDJSAI.SetActive(false);
    bbb.name="Sensitivity Changed";Destroy(cami,5f);at.SetActive(true); ut.SetActive(true);
    Destroy(coma,5f);
    rrr.name="Sensitivity Changed";pentileayam.SetActive(true);pentilesapi.SetActive(true);peju.SetActive(true);

    Plor=true;
    tetaelek.peler = false;
    AvaibleToWithdraw=false;

     if(b.Length>0&&r.Length>0 && bokep)
        {if(!sfkd){ l.p();sfkd=true;}else{
            Debug.Log("errorkont");
        }
        }else{if(bokep){PlayerPrefs.SetInt("kntl",1);SceneManager.LoadScene("Train");}
   }
        }
        if(Asdf<40)
        {
     dpn.text = "Match Started In : "+Asdf;
     aseli.text = "Match Started In : "+Asdf;
        }else{
            dpn.text = "Atleast 1 Player/Team";
            aseli.text = "Atleast 1 Player/Team";
        }
        bl.text = ""+b.Length+"/3";
        rd.text = ""+r.Length+"/3";
        bld.text = ""+b.Length+"/3 Players";
        rdd.text = ""+r.Length+"/3 Players";
        
    }
    void pler()
    {if(!Plor)
    {
        if(b.Length>0&&r.Length>0)
        {
         
        Asdf-=1;
        }else{
            Scene s = SceneManager.GetActiveScene();
    if(s.name!="SampleScene")
    {}else{
            //40
             Asdf-=1;}
        }
        Invoke("pler",1);
    }
    }
}
