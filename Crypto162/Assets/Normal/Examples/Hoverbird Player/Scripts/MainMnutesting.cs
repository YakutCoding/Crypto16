using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class MainMnutesting : MonoBehaviour
{public TMP_InputField t;
public TextMeshProUGUI status;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void setName()
    {
        if(t.text.Length>3 &&t.text.Length<17&&(!t.text.Contains("<")))
        {
         PlayerPrefs.SetString("DefaultName",t.text);
         SceneManager.LoadScene("MainMenu");
        }else{
            status.text= "Name Atleast 4 characters, max 16 char";
        }
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
