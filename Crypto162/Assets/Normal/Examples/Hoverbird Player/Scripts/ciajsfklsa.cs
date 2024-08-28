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
       print("kntlcia"+other.gameObject.transform.parent.gameObject.name);
           other.gameObject.transform.parent.GetComponent<takpct>().jkl();
           
        
    }
}
