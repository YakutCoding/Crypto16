using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.UI;

public class daoigadiojgadjgjakldjnglkans : MonoBehaviour
{
    public Toggle sigma;
    public Button Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(sigma.isOn)
        {
            Button.interactable=true;
        }else{
             Button.interactable=false;
        }
    }
    public void dsaipj(string arg)
    {
        Application.OpenURL(arg);
    }
}
