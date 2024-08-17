using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.UI;

public class btnclk : MonoBehaviour
{
    public AudioSource c;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(c.Play);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
