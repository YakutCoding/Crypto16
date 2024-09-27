using System.Collections;
using System.Collections.Generic;
using UnityEngine;using System;
using TMPro;
public class KJADGJDAK : MonoBehaviour
{
    public TMP_InputField t;
    public bool sikma,up;
    public TextMeshProUGUI[] tt;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void u()
    {
        if(!up)
        {
        up=true;
        }else{
            up=false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(sikma)
        {
            if(up)
            {
                foreach(TextMeshProUGUI a in tt)
                {
                       a.text = (char.ToUpper((Convert.ToChar(a.text)))).ToString();
                }
            }else{
                foreach(TextMeshProUGUI a in tt)
                {
                    a.text = (char.ToLower((Convert.ToChar(a.text)))).ToString();
                }
            }
        }
    }
    public void b()
    {
        t.text = t.text.Remove(t.text.Length-1);
    }
    public void suikma(string pusi)
    {
        if(sikma){
            if(up)
            {
                t.text += pusi;    
            }else{
                 t.text += (char.ToLower((Convert.ToChar(pusi)))).ToString();
            }
        }else{
        t.text += pusi;}
    }
}
