using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TMPro;
using EasyUI.Toast;
public class Survey : MonoBehaviour
{

    [SerializeField] TMP_InputField asd;

    string TESTER_URL = "https://docs.google.com/forms/d/e/1FAIpQLSd7dlw-eH2TdHgQNYTjNeiWG3efbFaMapDVR7gsx6hByAgCjw/formResponse";
    string Status="ENDED";
    public string pusi;
    public string puso;
    public TextMeshProUGUI t;
    
    
    public void Send()
    {
        if(asd.text.Length>0&&PlayerPrefs.GetInt(puso)>0)
        {
        StartCoroutine(Post(asd.text));
        }
    }

    IEnumerator Post(string s2)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.170139962", PlayerPrefs.GetString(pusi));
        form.AddField("entry.648130115", s2);
        form.AddField("entry.2020056138",""+t.text);
        PlayerPrefs.SetInt(puso,0);
        Toast.Show("Success!");


        UnityWebRequest www = UnityWebRequest.Post(TESTER_URL, form);
        
        yield return www.SendWebRequest();

    }


}