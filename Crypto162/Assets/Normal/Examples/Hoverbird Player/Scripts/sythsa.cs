using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sythsa : MonoBehaviour
{
    public takpct t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {Debug.Log("pusi"+other.name);
        t.fughj(other);
        
    }
}
