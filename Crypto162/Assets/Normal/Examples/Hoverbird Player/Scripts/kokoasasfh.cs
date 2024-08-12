using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class kokoasasfh : MonoBehaviour
{
    public int width;
    public GameObject[] BtnJoystickCtrl;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject a in BtnJoystickCtrl)
        {
            a.SetActive(false);
        }
        BtnJoystickCtrl[PlayerPrefs.GetInt("hro")].SetActive(true);
        width = PlayerPrefs.GetInt("hro");
    }
}
