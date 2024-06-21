using System.Collections;
using System.Collections.Generic;
using UnityEngine;using Normal.Realtime;
using System.Linq;
public class sapikurban : MonoBehaviour
{
    public string supri;
    public string suprii{get=>supri;set=>supri=value;}
    public RealtimeView r;
    public zkvkwa[] ba,ut;
    public takpct GameSoundVolume;
    public HoverbirdPlayer pler;
  int[] GameControllerSettingsIndex;
    int[] GameSensitivity;
    public GameObject[] uasu;
    bool pentileayam;
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        if(r.isOwnedLocallyInHierarchy)
        {
            GameManager a = GameObject.Find("GameController").GetComponent<GameManager>();
            suprii = a.pler  + "," + a.pli + ","+a.plo + ","+a.kepalasekolah;
        }
        if(suprii.Length>0)
        {
        GameSensitivity = suprii.Split(",").Select(x => int.Parse(x))
                                      .ToArray();
                                      if(!pentileayam)
                                      {
                                        GameControllerSettingsIndex = GameSensitivity;
                                        pentileayam=true;
                                      }
        GameSoundVolume.mxtk = GameSensitivity[2];
        foreach(zkvkwa a in ba)
        {
            a.Zkvkwa = GameSensitivity[0];
        } foreach(zkvkwa b in ut)
        {
            b.Zkvkwa = GameSensitivity[1];
        }
        pler.GameControlInput = GameSensitivity[3];
        
        
        for(int x=0;x<3;x++)
        {
            if(GameControllerSettingsIndex[x]!= GameSensitivity[x])

            {
                uasu[x].SetActive(true);
            }
        }
        }
        
    }
}
