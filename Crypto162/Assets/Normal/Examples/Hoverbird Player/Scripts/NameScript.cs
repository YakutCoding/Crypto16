using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;using Normal.Realtime;
public class NameScript : MonoBehaviour
{
    public TextMeshProUGUI nametext;
    public string name;
    public string Name{get=>name;set=>name=value;}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
        {
        Name=PlayerPrefs.GetString("DefaultName");
        }
        gameObject.name = Name;
        nametext.text = gameObject.name;
    }
}
