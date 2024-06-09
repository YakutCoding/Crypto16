#if NORMCORE

using UnityEngine;
using UnityEngine.Animations;

namespace Normal.Realtime.Examples {
    public class HoverbirdPlayerManager : MonoBehaviour {
        [SerializeField] private GameObject _camera = default;
         [SerializeField] private GameObject _prefab;
          public NormcoreAppSettings[] Server;
        private NormcoreAppSettings[][] groupAppSettings;
        private Realtime _realtime;
        public GameObject playercount,uicount;
        
        private void Awake() {
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
            {
_realtime.Connect(PlayerPrefs.GetInt("Room").ToString());
_realtime.didConnectToRoom += DidConnectToRoom;

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
            // Get a reference to the player
            HoverbirdPlayer player = playerGameObject.GetComponent<HoverbirdPlayer>();

            // Get the constraint used to position the camera behind the player
            ParentConstraint cameraConstraint = _camera.GetComponent<ParentConstraint>();

            // Add the camera target so the camera follows it
            ConstraintSource constraintSource = new ConstraintSource { sourceTransform = player.cameraTarget, weight = 1.0f };
            int constraintIndex = cameraConstraint.AddSource(constraintSource);

            // Set the camera offset so it acts like a third-person camera.
            cameraConstraint.SetTranslationOffset(constraintIndex, new Vector3( 0.0f,  5.2f, -34.9f));
            cameraConstraint.SetRotationOffset   (constraintIndex, new Vector3(15.0f,  0.0f,  0.0f));
        }
    }
}

#endif
