using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ciajsfklsa : MonoBehaviour
{
    public GameObject pusitaik;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.name=="Sphere"&&other.GetComponent<plerekudajir>()!=null)
        {
           pusitaik.SetActive(true);
        }
    }
}
