using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kntolbabi : MonoBehaviour
{
    public Animator teamanim,camo;
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        //WKWKWKKWW CHEATER TOL0L, MAU NGEDUMP KAH? MAKAN INI SCRIPT ANEH ANEH...
    }

    // Update is called once per frame
    void Update()
    {
        if(SimpleInput.GetButtonDown("Blue")||SimpleInput.GetButtonDown("Red"))
        {
        teamanim.Play("teamdoneselect");
        camo.Play("camo");
        Destroy(cam,2);
        }
    }
}
