using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cikntl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] pler = GameObject.FindGameObjectsWithTag("Bot");
        if(pler.Length<1)
        {
            SceneManager.LoadScene("wl");
        }
    }
}
