using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class MainMnutesting : MonoBehaviour
{public TMP_InputField t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetString("DefaultName",t.text);
    }
    public void Slecthero(int knto)
    {
        PlayerPrefs.SetInt("hro",knto);

    }
    public void goscene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
