using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class sslooaspew : MonoBehaviour
{

    public GameObject UI;
    public Transform UI_Button_Attack;
    public float ButtonAttackCode;


    public int _c = 0; 
  
    public int firstlengthofUI;

    private void Awake()
    {
        firstlengthofUI = PlayerPrefs.GetInt("LengthUI");
    }

    private void Update()
    {if(firstlengthofUI!=PlayerPrefs.GetInt("LengthUI")){
        PlayerPrefs.SetInt("LengthUI",0);
        //Reset to default length if the length of button is bad
    }}
}