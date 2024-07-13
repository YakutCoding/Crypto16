using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plinesapi : MonoBehaviour
{
    public GameObject pler,plor,plar;
    int plo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("pusimak"+plo)==1)
        {
            pler.SetActive(false);
            plor.SetActive(true);
            if(PlayerPrefs.GetInt("hro")==plo)
            {
                plar.SetActive(true);plor.SetActive(true);
            }
        }
    }
}
