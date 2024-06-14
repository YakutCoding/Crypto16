using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
public class hpce : MonoBehaviour
{
    public string HPCE;
    public float dur;
    public Animator da;
    public AnimSync a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SimpleInput.GetButtonDown(HPCE))
        {
            a.Play(HPCE,dur);
        }
    }
    public void Shake()
    {
da.Play("GameUtility");
    }
}
