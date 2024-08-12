using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aoifhaoisa : MonoBehaviour
{
    public GameObject[] ImageJoystick;
    public string s;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject a in ImageJoystick)
        {
            a.SetActive(false);
        }
        ImageJoystick[PlayerPrefs.GetInt(s)].SetActive(true);
    }
    public void ciga()
    {
foreach(GameObject a in ImageJoystick)
        {
            a.SetActive(false);
        }
        ImageJoystick[PlayerPrefs.GetInt(s)].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
