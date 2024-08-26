using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adfhhuiadlfhi : MonoBehaviour
{
    public bool saj,rilods;
    public GameObject sadj,nosaj;
    public Transform p;
    float pks;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        if(saj)
        {
            pks = Random.Range(0.51f,1.00f);
        }else{
              pks = Random.Range(1.00f,2.00f);
        }
        Invoke("rilod",Random.Range(4,8));
        Invoke("pukimay",pks);
    }
    void rilod()
    {
        rilods=true;anim.Play("r");
        Invoke("rilod",Random.Range(8,12));
        Invoke("suki",1);
    }
    void suki()
    {
        rilods=false;Invoke("pukimay",pks);
    }
    void pukimay(){
        if(!rilods)
        {
        anim.Play("s");
        if(saj)
        {
        Instantiate(sadj,p.position,p.rotation);}else{
              Instantiate(nosaj,p.position,p.rotation);}
        
        Invoke("pukimay",pks);}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
