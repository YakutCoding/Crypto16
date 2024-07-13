using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class plerekurbanjir : MonoBehaviour
{
    public TextMeshProUGUI t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(t.text.Contains("y"))

{
    t.text = "DEFEAT";
} 

 if(t.text.Contains("Y"))

{
    t.text = "VICTORY";
} 
   }
}
