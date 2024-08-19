using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kdudwe : MonoBehaviour
{
    public GameObject j;
    public int lengthOfUI;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("WidthUI"+lengthOfUI)==1)
        {
            j.SetActive(false);
        }else{
            j.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
