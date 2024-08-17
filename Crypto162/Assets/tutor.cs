using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutor : MonoBehaviour
{
public GameObject a,b;
    // Start is called before the first frame update
    void Start()
    {
        sigma();
    }
public void sigma()
{ a.SetActive(false);
    b.SetActive(false);
   Invoke("sugma",32);
}
void sugma()
{
     a.SetActive(true);
    b.SetActive(true);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
