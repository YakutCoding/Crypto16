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
    ProtectedValue canvasWidth;

    private void Awake()
    {
        _c = PlayerPrefs.GetInt("LengthUI");
     canvasWidth = new ProtectedValue(_c);
 
        _e();
    }

    private void Update()
    {_c = PlayerPrefs.GetInt("LengthUI");
        if (canvasWidth.CompareValue(_c))
        {
            
        }else{
  _c = canvasWidth.GetInt();
  PlayerPrefs.SetInt("LengthUI",_c);
  SceneManager.LoadScene("Lag");// Disconnect if Width Doesnt perfect

        }
    }

    private void _e()
    {
        canvasWidth = new ProtectedValue(_c);
        _c = canvasWidth.GetInt();
    }
    public void kntol()
    {
        
    }

    private void _f()
    {
        if (canvasWidth.CompareValue(_c))
        {
            _c = PlayerPrefs.GetInt("LengthUI");
            canvasWidth.ApplyNewValue(_c);
        }
        else
        {
            _c = canvasWidth.GetInt();
            Debug.LogError("CHEAT DETECTED!");
        }
    }
}
