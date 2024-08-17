using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sfasojhgai : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("UILENGTHSETTED")==0)
        {
             PlayerPrefs.SetInt("LengthUI",99990);
             PlayerPrefs.SetInt("UILENGTHSETTED",1);
        }
        SceneManager.LoadScene("MainMenu");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
