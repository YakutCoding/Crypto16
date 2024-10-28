using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proyecto26;using UnityEngine.SceneManagement;
using EasyUI.Toast;using TMPro;
public class sydacj : MonoBehaviour
{
    public static string sis;
    public sadf sd;
    public string[] sikm;
    public static string dfd;
    private string pl;public GameObject dfld;
    public TMP_InputField sui;
    public GameObject pler;
    // Start is called before the first frame update
    void Start()
    {
        foreach(string a in sikm)
        {
            pl+=a+":"+PlayerPrefs.GetInt(a) +";";
        }
        pl=pl.Remove(pl.Length-1,1);
        dfd=pl;sis=PlayerPrefs.GetString("DefaultName");
  if(int.Parse(System.DateTime.UtcNow.ToString("dd"))!= PlayerPrefs.GetInt("dd"))
  {
    PlayerPrefs.SetInt("dd",int.Parse(System.DateTime.UtcNow.ToString("dd")));
    Invoke("asjfo",1f);
  }
    }

   public  void asjfo()
    {
      if(PlayerPrefs.GetInt("skfghq")>0)
      {
        sadf ur = new sadf();
        RestClient.Put("https://blitzarena-c26d1-default-rtdb.firebaseio.com/" +PlayerPrefs.GetString("sdksg") + ".json", ur);pler.SetActive(true);
      }
 
        
    }
     public  void kcoa()
    {
  
        sadf ur = new sadf();
        RestClient.Put("https://blitzarena-c26d1-default-rtdb.firebaseio.com/" +PlayerPrefs.GetString("sdksg") + ".json", ur);
        PlayerPrefs.SetInt("skfghq",1);
 
        
    }
    void Decrypt(string s)
    {
        string[] ass = s.Split(";");
        foreach(string b in ass)
        {
            string[] suk = b.Split(":");
            PlayerPrefs.SetInt(suk[0],int.Parse(suk[1]));
        }

    }
    public void ghe()
    {dfld.SetActive(true);
        RestClient.Get<sadf>("https://blitzarena-c26d1-default-rtdb.firebaseio.com/" +sui.text + ".json").Then(response=> 
        
       { sd = response;Decrypt(sd.fdf);PlayerPrefs.SetString("DefaultName",sd.asa);PlayerPrefs.SetInt("skfghq",1);PlayerPrefs.SetString("sdksg",sui.text.Replace(" ",""));SceneManager.LoadScene("MainMenu");}).Catch(error => { dfld.SetActive(false);Toast.Show("not found");

       });
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("skfghq")>0)
        {
            pler.SetActive(true);
        }
    }
}

public class sadf{
    public string asa;
    public string fdf;
    public sadf(){
asa= sydacj.sis;
fdf = sydacj.dfd;
    }
}