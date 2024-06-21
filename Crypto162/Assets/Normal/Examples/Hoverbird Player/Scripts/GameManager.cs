using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject skibidisigma;
    public int pler,pli,plo,kepalasekolah;
    public int[] psa,psi,spo;
    public GameObject kng,gl;
    public pentilebabi p;
    // Start is called before the first frame update
    void Start()
    {
        pler = psa[PlayerPrefs.GetInt("hro")];
        pli = psi[PlayerPrefs.GetInt("hro")];
        plo = spo[PlayerPrefs.GetInt("hro")];
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
