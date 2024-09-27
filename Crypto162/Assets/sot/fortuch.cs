using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;using UnityEngine.UI;
public class fortuch : MonoBehaviour
{
    public Button t;
    public TMP_InputField i;
    public GameObject ts;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(i.text.Length==42)
        { t.interactable=true;
ts.SetActive(false);
        }else{
            t.interactable=false;ts.SetActive(true);
        }
    }
}
