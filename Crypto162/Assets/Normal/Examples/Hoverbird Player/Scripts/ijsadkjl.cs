using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ijsadkjl : MonoBehaviour
{
    public TextMeshProUGUI UI_SENDMEX;
    public sslooaspew ass;

    void Update()
    {
        UI_SENDMEX.text = ""+(PlayerPrefs.GetInt("LengthUI")+10); //plus 10 pixel
        Debug.Log("Test Width And Length UI Set successfull");
    }
}
