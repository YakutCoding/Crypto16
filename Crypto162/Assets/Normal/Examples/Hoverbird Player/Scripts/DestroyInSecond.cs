using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
public class DestroyInSecond : MonoBehaviour
{
    public float Times;
    public bool isr;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("pentil",Times);
    }

    // Update is called once per frame
    void pentil()
    {
        if(isr)
        {
            if(GetComponent<RealtimeView>().isOwnedLocallyInHierarchy)
            {
                Realtime.Destroy(gameObject);
            }
        }else{
            Destroy(gameObject);
        }
    }
}
