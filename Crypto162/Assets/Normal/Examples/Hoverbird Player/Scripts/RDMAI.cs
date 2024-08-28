using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RDMAI : MonoBehaviour
{
    public GameObject[] a;
    public Image[] img;
    public Sprite g,ak;
    int pusi;
    // Start is called before the first frame update
    void Start()
    {
        pusi = Random.Range(0,3);
    }

    // Update is called once per frame
    void Update()
    {
        if(pusi==0)
        {
            a[0].SetActive(true);
            a[1].SetActive(true);
            img[0].sprite = g;
            img[1].sprite = ak;
        }else if(pusi==1)
        {
              a[0].SetActive(true);
            a[2].SetActive(true);  img[0].sprite = g;
            img[1].sprite = g;
        }else{
                  a[1].SetActive(true);
            a[3].SetActive(true);  img[0].sprite = ak;
            img[1].sprite = ak;
        }
    }
}
