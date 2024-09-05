using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jklawop : MonoBehaviour
{
    public int UILengthStabilizer;
    public int WidthUI;
    public GameObject A,B,C;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("WidthUI"+WidthUI)==1)
        {
        Destroy(A);
    B.SetActive(true);
        }
    }
    public void aosj()
    {
        if(PlayerPrefs.GetInt("LengthUI")>=UILengthStabilizer)
        {
            C.SetActive(false);
        PlayerPrefs.SetInt("LengthUI",PlayerPrefs.GetInt("LengthUI")-UILengthStabilizer);
        PlayerPrefs.SetInt("WidthUI"+WidthUI,1);
        PlayerPrefs.SetInt("WidthUIStabilizer",1);
        }
    }
    public void ButtonConfigInfo()
    {
        PlayerPrefs.SetString("ButtonConfigurationControl","{Ctrl}");

    }
}
