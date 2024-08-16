using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class mmgsfa : MonoBehaviour
{
    public GameObject sf;
    public GameObject RandomizeUILENGTHTEST;
    public string TESTUILENGT;
    public TextMeshProUGUI t;
    public int width,height;
    // Start is called before the first frame update
    void Start()
    {int sui=Random.Range(width,height);
        sf.SetActive(false);
        PlayerPrefs.SetInt("LengthUI",PlayerPrefs.GetInt("LengthUI")+sui);
        Invoke("pki",0.1f);
        t.text=""+sui
;    }
    void pki()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
