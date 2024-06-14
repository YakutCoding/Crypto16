using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
public class GoForward : MonoBehaviour
{
    public float kecepatan;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * kecepatan * Time.deltaTime);
    }
}
