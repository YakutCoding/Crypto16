using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class plerekudajir : MonoBehaviour
{
    public GameManager s;
    public RealtimeView r;
    public float pusi;
    float psi;

    // Start is called before the first frame update
    void Start()
    {
        s = GameObject.Find("GameController").GetComponent<GameManager>();
                 
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Revive" || other.tag == "pler")
        {
            pusi += 1f;
        }
    }
void CheckPosition()
{
    if(psi==pusi)
        {
           s.gl.SetActive(false);
    s.kng.SetActive(false);
    Debug.Log("Kontotoootl");
    Invoke("CheckPosition",0.5f);
        }
 else if(psi < pusi)
        {
            psi = pusi;
            s.gl.SetActive(true);
            s.kng.SetActive(true);   Debug.Log("Kont999otoootl");
            Invoke("CheckPosition",0.5f);
       
           
        }
        
                
}
    // Update is called once per frame
    void Update()
    {
        if(!r.isOwnedLocallyInHierarchy)
        {
            Destroy(gameObject.GetComponent<plerekudajir>());
            return;
        }
      

        
        if((gameObject.transform.position.x < 13f && gameObject.transform.position.x>-13f)&&((gameObject.transform.position.z < -70 && gameObject.transform.position.z>-90)||(gameObject.transform.position.z < 90 && gameObject.transform.position.z>64))&&gameObject.transform.position.y <4)
        {  if(!s.p.peler)
        {
            s.gl.SetActive(true);
            s.kng.SetActive(true); }
        }else{
            s.gl.SetActive(false);
            s.kng.SetActive(false); 
        }

       

    }
}
