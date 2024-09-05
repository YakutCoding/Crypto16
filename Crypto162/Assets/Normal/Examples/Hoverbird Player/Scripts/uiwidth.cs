using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiwidth : MonoBehaviour
{
    public GameObject c;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("WidthUIStabilizer")!=1)
        {
            c.SetActive(true);
        }
    }
}
