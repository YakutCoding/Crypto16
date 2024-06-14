using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automaticinst : MonoBehaviour
{
    public GameObject a;
    // Start is called before the first frame update
    void OnEnable()
    {
        Instantiate(a,gameObject.transform.position,gameObject.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
