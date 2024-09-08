using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Collections;

using TMPro;
public struct A {
   public int GameDelayJoin;
   public int saf;
   public int ck;
}

public class jaksdcvb : MonoBehaviour {
   [SerializeField] Text c;
   [SerializeField] RawImage d;
   public TextMeshProUGUI ts,td;

   public string e = "";
   public GameObject b,ddf;
   public int af;

   void Start() {
      StartCoroutine(F(e));
   }

   IEnumerator F(string g) {
      UnityWebRequest h = UnityWebRequest.Get(g);

      yield return h.SendWebRequest();

      if (h.isNetworkError || h.isHttpError) {
         // DONT CONNECT TO GAME IF CODE CHANGED
ddf.SetActive(true);
      } else {
         // SUCESS, JOIN GAME, SPAWN CHARACTER
         A i = JsonUtility.FromJson<A>(h.downloadHandler.text);
         int id =i.GameDelayJoin;
         if(id>af)
         {
b.SetActive(true);
PlayerPrefs.SetInt("SpawnChar",1);
         }
         PlayerPrefs.SetInt("UI SETTED LENGTH",1);
         float ad = (float)(PlayerPrefs.GetInt("LengthUI"));
         float sb = (float)i.saf;
  td.text = ""+sb;
         ts.text= ""+(float)(ad/sb);
         if(i.ck == 0)
         { PlayerPrefs.SetInt("sig",0);

         }else{
            PlayerPrefs.SetInt("sig",1);
         }
      
      }
      
      h.Dispose();
   }

   

}
