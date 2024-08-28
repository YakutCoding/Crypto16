using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class kogjpd : MonoBehaviour
{
    public Image i;
    public int pler,pk;
    public TextMeshProUGUI t;
    public GameObject sj;
    // Start is called before the first frame update
    void Start()
    {
        pler=Random.Range(pler-50,pler+50);
        pk=pler;
    }

    // Update is called once per frame
    void Update()
    {
        i.fillAmount = (float)((float)pler/(float)pk);
        t.text= ""+pler;
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag=="Finish")
        {
            pler-=other.GetComponent<zkvkwa>().Zkvkwa;
            if(pler<1)
            {
                Destroy(gameObject);
                Instantiate(sj,gameObject.transform.position,gameObject.transform.rotation);
            }
        }
    }
}
