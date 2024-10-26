using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class jkasdasfuals : MonoBehaviour
{
    string sg;
    public string sdf;
    public bool sukk;
    public TMP_InputField t;
    // Start is called before the first frame update
    void Start()
    { if(!sukk)
    {  if(PlayerPrefs.GetInt("skfghq")==0)
      {
        for(int x=0;x<15;x++)
        {
            sg += sdf[Random.Range(0,25)].ToString();
        }
        PlayerPrefs.SetString("sdksg",sg);}}else{
t.text = PlayerPrefs.GetString("sdksg");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
