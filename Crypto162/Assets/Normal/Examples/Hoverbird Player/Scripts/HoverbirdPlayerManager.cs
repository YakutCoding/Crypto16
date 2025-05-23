﻿#if NORMCORE

using UnityEngine;
using UnityEngine.Animations;
using TMPro;using UnityEngine.SceneManagement;using Normal.Realtime.Serialization;
namespace Normal.Realtime.Examples {
    public class HoverbirdPlayerManager : MonoBehaviour {
        [SerializeField] private GameObject _camera = default;
         [SerializeField] private GameObject _prefab;
          public NormcoreAppSettings[] Server;
        private NormcoreAppSettings[][] groupAppSettings;
        private Realtime _realtime;bool disc;
        public Animator pingk;
        public GameObject playercount,uicount,lolor,elelt,elelts;HoverbirdPlayer plat;
        public TextMeshProUGUI pingText,rum,sik;
        public int skibidi;
        public bool off;
        void kontolhitam()
        {
            if(_realtime.connected){
PlayerPrefs.SetInt("SGM",0);      PlayerPrefs.SetInt("skibidinew",0);
            }else{
                if(PlayerPrefs.GetInt("SGM")<2)
                {
                PlayerPrefs.SetInt("SGM",PlayerPrefs.GetInt("SGM")+1);SceneManager.LoadScene("SampleScene");
                }else{PlayerPrefs.SetInt("SGM",0);      PlayerPrefs.SetInt("skibidinew",0);
               PlayerPrefs.SetInt("kntl",1);
               SceneManager.LoadScene("Train");
         
                }
            }
        }
        void sikmamale()
        {skibidi++;
            if(skibidi<10)
            {
sik.text = "0"+skibidi;}else{
sik.text = ""+skibidi;
}
PlayerPrefs.SetInt("skibidinew",skibidi); Invoke("sikmamale",1);
        }
        private void Awake() {
          Invoke("kontolhitam",12);skibidi = PlayerPrefs.GetInt("skibidinew",skibidi);
            Invoke("sikmamale",0);
            // Get the Realtime component on this game object
            _realtime = GetComponent<Realtime>();
            int groupCount = (Server.Length + 15) / 16; // Menghitung jumlah grup
       
            groupAppSettings = new NormcoreAppSettings[groupCount][];

            for (int x = 0; x < groupCount; x++)
            {
                groupAppSettings[x] = new NormcoreAppSettings[32];

                for (int y = 0; y < 16; y++) 
                {
                    int serverIndex = (x * 32 + y) % Server.Length;
                    groupAppSettings[x][y] = Server[serverIndex];
                   
                }
                for (int y = 16; y < 32; y++)
                {
                    int serverIndex = (x * 32 + (y)) % Server.Length;
                    groupAppSettings[x][y] = Server[serverIndex];
                }
            }
                 int   Hari = int.Parse(System.DateTime.UtcNow.ToLocalTime().ToString("dd"));
            _realtime.normcoreAppSettings = groupAppSettings[PlayerPrefs.GetInt("Server")][Hari];
             Debug.Log("serverIndex"+groupAppSettings[PlayerPrefs.GetInt("Server")][Hari].name);
            // Notify us when Realtime successfully connects to the room
            Invoke("Connect",0.3f);
            
        }
            void Connect()
            {_realtime.didConnectToRoom += DidConnectToRoom;
                if(!off)
                {
_realtime.Connect(PlayerPrefs.GetInt("Room").ToString()+PlayerPrefs.GetInt("SGM"));
                }else{
                      _realtime.Connect(PlayerPrefs.GetInt("Room").ToString(), new Room.ConnectOptions {
            offlineMode = true
        });
                }


            }

        private void DidConnectToRoom(Realtime realtime) {
            // Instantiate the Player for this client once we've successfully connected to the room
            var options = new Realtime.InstantiateOptions {
                ownedByClient            = true,    // Make sure the RealtimeView on this prefab is owned by this client.
                preventOwnershipTakeover = true,    // Prevent other clients from calling RequestOwnership() on the root RealtimeView.
                useInstance              = realtime // Use the instance of Realtime that fired the didConnectToRoom event.
            };
            GameObject playerGameObject = Realtime.Instantiate(_prefab.name, options);
playercount.SetActive(true);
uicount.SetActive(true);
lolor.SetActive(false);
elelt.SetActive(true);elelts.SetActive(true);
            // Get a reference to the player
            HoverbirdPlayer player = playerGameObject.GetComponent<HoverbirdPlayer>();

            // Get the constraint used to position the camera behind the player
            ParentConstraint cameraConstraint = _camera.GetComponent<ParentConstraint>();
            plat = player;

            // Add the camera target so the camera follows it
            ConstraintSource constraintSource = new ConstraintSource { sourceTransform = player.cameraTarget, weight = 1.0f };
            int constraintIndex = cameraConstraint.AddSource(constraintSource);

            // Set the camera offset so it acts like a third-person camera.
            cameraConstraint.SetTranslationOffset(constraintIndex, new Vector3( 0.0f,  5.5f, -29.2f));
            cameraConstraint.SetRotationOffset   (constraintIndex, new Vector3(15.0f,  0.0f,  0.0f));
        }

        void Update()
        {     
            rum.text = "Room "+ PlayerPrefs.GetInt("Room");
            float Ping = _realtime.ping;
            bool StatusRoom = _realtime.disconnected;
            pingText.text = ((int)(Ping/4)).ToString() + " ms";
            if(Ping/4 > 110)
            {
                print("Lag bgt co");
            }
            if(Ping/4>70 && Ping/4< 101)
            {
                plat.LagMultiplier = 40/(Ping/4);
                pingk.Play("YellowPing");
            }else if(Ping/4<81){
                plat.LagMultiplier = 1f;
            }
            if(Ping/4> 100)
            {plat.LagMultiplier = 30/(Ping/4);
            if(!disc)
            {
            Invoke("Disconnectd",8);
            disc=true;
            }
                pingk.Play("RedPing");
            }else if(Ping/4 < 71)
            {
                pingk.Play("GreenPink");
                disc=false;
                CancelInvoke("Disconnectd");
            }
            if(StatusRoom)
            {
                print("Disconnectjir");
                SceneManager.LoadScene("Lag");
            }
        }
             void Disconnectd()
        {
            SceneManager.LoadScene("Lag");
           
        }
    }
}

#endif
