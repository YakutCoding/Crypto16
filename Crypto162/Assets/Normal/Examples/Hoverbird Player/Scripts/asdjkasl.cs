using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class asdjkasl : MonoBehaviour
{
    public int a,b;
    public TextMeshProUGUI t;
    // Start is called before the first frame update
    void Start()
    {   
        int ass = Random.Range(a,b);
        PlayerPrefs.SetInt("WidthUI",PlayerPrefs.GetInt("LengthUI")+ass);
        PlayerPrefs.SetInt("ScaleUI",PlayerPrefs.GetInt("LengthUI")+ass);
        PlayerPrefs.SetInt("LengthUI",PlayerPrefs.GetInt("LengthUI")+ass);
        PlayerPrefs.SetInt("HeightUI",PlayerPrefs.GetInt("LengthUI")+ass);
        t.text=""+ass;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
