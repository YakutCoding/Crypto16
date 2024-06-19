using Normal.Realtime;using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class peliKambing : MonoBehaviour
{
    public TextMeshProUGUI pli,pla;
    
     public float zX34l = 300; 
    public TextMeshProUGUI yQ12k,usu,esek;
    private bool vN89m = false;
    public GameObject done;
    public TextMeshProUGUI Vc;
    public Color asu,asi;
    public int curentb,curentr;
    public Animator bb,rr;
    // Start is called before the first frame update
    void Start()
    {
         vN89m = true;
        C34kT(zX34l);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] pl = GameObject.FindGameObjectsWithTag("Player");
        GameObject[] a = GameObject.FindGameObjectsWithTag("Respawn"); GameObject[] b = GameObject.FindGameObjectsWithTag("EditorOnly");
        if(curentb!=b.Length)
        {
bb.Play("Pentol");
        }if(curentr!=a.Length)
        {
            rr.Play("Pentol")
;        }
        curentb = b.Length;curentr = a.Length;
        pli.text = ""+a.Length;
        pla.text = ""+b.Length;
        usu.text = pli.text;
        esek.text = pla.text;
        foreach(GameObject ass in pl)
            {
        if(a.Length>6)
        {
            
            if(ass.GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
            {
                if(!ass.GetComponent<cakv>().Cakvs.Contains("b"))
                {
                        done.SetActive(true);Vc.color = asu;
                        Vc.text = "VICTORY";
                }else{
 done.SetActive(true);Vc.color = asi;
                        Vc.text = "DEFEAT";
                }
            }
        }     if(b.Length>6)
        {
            
            if(ass.GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
            {
                if(ass.GetComponent<cakv>().Cakvs.Contains("b"))
                {
                        done.SetActive(true);Vc.color = asu;
                        Vc.text = "VICTORY";
                }else{
 done.SetActive(true);Vc.color = asi;
                        Vc.text = "DEFEAT";
                }
            }
        }}
        if (vN89m)
        {
            if (zX34l > 0)
            {
                zX34l -= Time.deltaTime;
                C34kT(zX34l);
            }
            else
            {done.SetActive(true);
               Vc.text="TIMES OUT";
            Vc.color=Color.white;
                zX34l = 0;
                vN89m = false;
                C34kT(zX34l);
            }
        }
        
    }
    void C34kT(float tR90d)
    {
        tR90d += 1;

        float mR73s = Mathf.FloorToInt(tR90d / 60);
        float sT54n = Mathf.FloorToInt(tR90d % 60);

        yQ12k.text = string.Format("{0:00}:{1:00}", mR73s, sT54n);
    }
}
