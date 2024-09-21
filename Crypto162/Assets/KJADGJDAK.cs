using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class KJADGJDAK : MonoBehaviour
{
    public TMP_InputField t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void b()
    {
        t.text = t.text.Remove(t.text.Length-1);
    }
    public void suikma(string pusi)
    {
        t.text += pusi;
    }
}
