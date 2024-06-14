using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
public class AnimSync : MonoBehaviour
{
    public string anim;
    public string Anim{get=>anim;set=>anim=value;}
    public Animator[] t;
    public RealtimeView r;
    bool isOtherAnim,ba;
    KrkTerCuk K;
    // Start is called before the first frame update
    void Done()
    {if(Anim.Contains("Basic")||Anim.Contains("Jump")||Anim.Contains("Ulti"))
            {
                ba=false;
            }
       Anim=""; isOtherAnim=false;PlayerPrefs.SetInt("jalan",1);
    }
    public void Play(string a,float b)
    {
        if(!isOtherAnim)
        {
        if(r.isOwnedLocallyInHierarchy)
        {
            Anim=a;
            Invoke("Done",b);
            isOtherAnim=true;
            PlayerPrefs.SetInt("jalan",0);
        }
        }
    }

    // Update is called once per frame
    void Update()
    {K=GetComponent<KrkTerCuk>();foreach(Animator z in t)
        {
        z.Play(Anim);
        }
        if(r.isOwnedLocallyInHierarchy)
        {
        if(!ba)
        {
            if(K.Cuk==2)
            {    if(SimpleInput.GetButtonDown("Attack"))
        {ba=true;
            int r = Random.Range(0,2);
            if(r==1)
            {
            Play("BasicAttack2Mage",0.75f);PlayerPrefs.SetInt("jalan",0);
        }else{
            Play("BasicAttack1",0.75f);PlayerPrefs.SetInt("jalan",0);
        }}
            }else{
        if(SimpleInput.GetButtonDown("Attack"))
        {ba=true;
            int r = Random.Range(0,2);
            if(r==1)
            {
            Play("BasicAttack2",0.75f);PlayerPrefs.SetInt("jalan",0);
        }else{
            Play("BasicAttack1",0.75f);PlayerPrefs.SetInt("jalan",0);
        }}
        }
        }
        if(SimpleInput.GetButtonDown("Jump"))
        {
            
        }
        if(SimpleInput.GetAxis("Horizontal")!=0 || SimpleInput.GetAxis("Vertical")!=0)
        {
            if(!isOtherAnim)
            {
Anim = "Walk";
PlayerPrefs.SetInt("jalan",1);
            }
        }else{
            if(!isOtherAnim)
            {
                Anim = "Idle";PlayerPrefs.SetInt("jalan",0);
            }
        }}
}
}
