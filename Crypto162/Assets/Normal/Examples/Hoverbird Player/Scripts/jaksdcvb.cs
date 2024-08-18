using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Collections;


public struct A {
   public int GameDelayJoin;
}

public class jaksdcvb : MonoBehaviour {
   [SerializeField] Text c;
   [SerializeField] RawImage d;

   public string e = "";
   public GameObject b;
   public int af;

   void Start() {
      StartCoroutine(F(e));
   }

   IEnumerator F(string g) {
      UnityWebRequest h = UnityWebRequest.Get(g);

      yield return h.SendWebRequest();

      if (h.isNetworkError || h.isHttpError) {
         // DONT CONNECT TO GAME IF CODE CHANGED

      } else {
         // SUCESS, JOIN GAME, SPAWN CHARACTER
         A i = JsonUtility.FromJson<A>(h.downloadHandler.text);
         int id =i.GameDelayJoin;
         if(id>af)
         {
b.SetActive(true);
PlayerPrefs.SetInt("SpawnChar",1);
         }
      
      }
      
      h.Dispose();
   }

   

}
