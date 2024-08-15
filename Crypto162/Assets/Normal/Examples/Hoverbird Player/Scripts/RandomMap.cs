using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMap : MonoBehaviour
{
    public GameObject mp;
    public GameObject[] maps;
    public Material[] mat;
    // Start is called before the first frame update
    void Start()
    {
        int pler = Random.Range(0,mat.Length);
        mp.GetComponent<Renderer>().material = mat[pler];
        maps[pler].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
