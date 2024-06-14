using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;using UnityEngine.UI;
public class Missionnigger : MonoBehaviour
{
    public Image[] kntor,kntob;
    public TextMeshProUGUI[] pler,pleb;
    public Sprite[] sui;
    GameObject[] plery;
      public cakv[] b,r;
      public KrkTerCuk[] bb,rr;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         GameObject[] allCakvs = GameObject.FindGameObjectsWithTag("Player");

        // List sementara untuk menyimpan Cakv dengan Cakvs = "xkdrkr" dan "xkdrkb"
        var tempListR = new List<cakv>();
        var tempListB = new List<cakv>();

        // Memasukkan game object ke dalam list sementara r dan b
        foreach (GameObject obj in allCakvs)
        {
            cakv cakvScript = obj.GetComponent<cakv>();
            if (cakvScript != null)
            {
                if (cakvScript.Cakvs == "xkdrkr")
                {
                    tempListR.Add(cakvScript);
                }
                else if (cakvScript.Cakvs == "xkdrkb")
                {
                    tempListB.Add(cakvScript);
                }
            }
        }
        

        // Mengkonversi list sementara ke dalam array r dan b
        r = tempListR.ToArray();
        b = tempListB.ToArray();
var tempListRr = new List<KrkTerCuk>();
        var tempListBb = new List<KrkTerCuk>();
        foreach(cakv a in r)
        {
tempListRr.Add(a.GetComponent<KrkTerCuk>());
        }foreach(cakv a in b)
        {
tempListBb.Add(a.GetComponent<KrkTerCuk>());
        }
        bb= tempListBb.ToArray();
        rr = tempListRr.ToArray();
        for(int x=0;x<rr.Length;x++)
        {
kntor[x].gameObject.SetActive(true);
kntor[x].sprite = sui[rr[x].Cuk];
pler[x].text = rr[x].gameObject.name;
pler[x].gameObject.SetActive(true);
        }for(int x=0;x<bb.Length;x++)
        {
kntob[x].gameObject.SetActive(true);
kntob[x].sprite = sui[bb[x].Cuk];
pleb[x].text = bb[x].gameObject.name;pleb[x].gameObject.SetActive(true);
        }

        
    }
}
