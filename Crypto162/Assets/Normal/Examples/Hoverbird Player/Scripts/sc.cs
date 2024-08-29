using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class sc : MonoBehaviour
{
    [Header("knto kl bth timer")
    ]
    public float timer;
    public string pusi;
    public bool awl;
    // Start is called before the first frame update
    void Start()
    {
        if(awl)
        {
        SceneManager.LoadScene(pusi);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void pentil(string knto)
    {
        if(timer>0)
        {
Invoke("pusimay",timer);
        }else{
        SceneManager.LoadScene(knto);
        }
    }
    void pusimay()
    {
        SceneManager.LoadScene(pusi);
    }
}
