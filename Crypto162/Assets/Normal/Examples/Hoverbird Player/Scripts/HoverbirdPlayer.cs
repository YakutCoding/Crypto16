﻿

using UnityEngine;
using Normal.Realtime;
    public class HoverbirdPlayer : MonoBehaviour {
        // Camera
        public  Transform  cameraTarget;
        private float     _mouseLookX;
        private float     _mouseLookY;

        // Physics
        private Vector3   _targetMovement;
        private Vector3   _movement;

        private bool      _jumpThisFrame;
        private bool      _jumping;

        private Rigidbody _rigidbody;
        bool isGrounded=true;
        public float GameControlInput;

        // Character
        [SerializeField] private Transform _character = default;

        // Multiplayer
        private RealtimeView _realtimeView;
        public float sl;
        public AnimSync a;
    public Animator bapak;
    public float LagMultiplier;
    public float speedMult;
        void OnTriggerEnter(Collider other)
        {
           

        }
    
        private void Awake() {
            // Set physics timestep to 60hz
            Time.fixedDeltaTime = 1.0f/60.0f;

            // Store a reference to the rigidbody for easy access
            _rigidbody = GetComponent<Rigidbody>();

            // Store a reference to the RealtimeView for easy access
            _realtimeView = GetComponent<RealtimeView>();
        }

        private void Start() {
            // Call LocalStart() only if this instance is owned by the local client
            if (_realtimeView.isOwnedLocallyInHierarchy)
            {                LocalStart(); gameObject.transform.position = new Vector3(gameObject.transform.position.x,-275,gameObject.transform.position.z);}
        }

        private void Update() {
            // Call LocalUpdate() only if this instance is owned by the local client
            if (_realtimeView.isOwnedLocallyInHierarchy){
                LocalUpdate();}else{
                    Destroy(gameObject.GetComponent<HoverbirdPlayer>());
                }
        }

        private void FixedUpdate() {

            // Call LocalFixedUpdate() only if this instance is owned by the local client
            if (_realtimeView.isOwnedLocallyInHierarchy)
            {
                if(SimpleInput.GetButtonDown("UltiBot4"))
                {
                    if(PlayerPrefs.GetInt("hro")==3 || PlayerPrefs.GetInt("hro")==7)//if it isnt idle, and ready to walk
                    {
                    speedMult=7.5f;
                    Invoke("doneSprint",0.4f);
                    }
                }
                if(gameObject.transform.position.y>33)
                {
                    _rigidbody.AddForce(transform.up * -9000);
                }
                LocalFixedUpdate();}else{
                    Destroy(gameObject.GetComponent<HoverbirdPlayer>());
                }
        }
        void doneSprint()
        {
            speedMult=1;
        }

        private void LocalStart() {
            // Request ownership of the Player and the character RealtimeTransforms
                       GetComponent<RealtimeTransform>().RequestOwnership();
            _character.GetComponent<RealtimeTransform>().RequestOwnership();
        }

        private void LocalUpdate() {
            // Move the camera using the mouse
            RotateCamera();

            // Use WASD input and the camera look direction to calculate the movement target
            CalculateTargetMovement();

            // Check if we should jump this frame
            CheckForJump();
            if(SimpleInput.GetButtonDown("Blue"))
            {
gameObject.transform.position = new Vector3(Random.Range(-90,90),9,Random.Range(30,86));
            }else if(SimpleInput.GetButtonDown("Red"))
            {
                gameObject.transform.position = new Vector3(Random.Range(-90,90),9,Random.Range(-86,-30));
            }
        }

        private void LocalFixedUpdate() {
            // Move the player based on the input
            MovePlayer();

            // Animate the character to match the player movement
            AnimateCharacter();
        }

        private void RotateCamera() {
            // Get the latest mouse movement. Multiple by 4.0 to increase sensitivity.
            _mouseLookX += SimpleInput.GetAxis("MouseX") * 4.0f;
            _mouseLookY += SimpleInput.GetAxis("MouseY") * 4.0f;

            // Clamp how far you can look up + down
            while (_mouseLookY < -180.0f) _mouseLookY += 360.0f;
            while (_mouseLookY >  180.0f) _mouseLookY -= 360.0f;
            _mouseLookY = Mathf.Clamp(_mouseLookY, -15.0f, 15.0f);

            // Rotate camera
            cameraTarget.localRotation = Quaternion.Euler(-_mouseLookY, _mouseLookX, 0.0f);
        }

        private void CalculateTargetMovement() {
            // Get input movement. Multiple by 6.0 to increase speed.
            Vector3 inputMovement = new Vector3();
            inputMovement.x = (SimpleInput.GetAxisRaw("Horizontal") * (45f+(float)GameControlInput))*LagMultiplier*speedMult;
            inputMovement.z = (SimpleInput.GetAxisRaw("Vertical")   * (45f+(float)GameControlInput))* LagMultiplier*speedMult;

            // Get the direction the camera is looking parallel to the ground plane.
            Vector3    cameraLookForwardVector = ProjectVectorOntoGroundPlane(cameraTarget.forward);
            Quaternion cameraLookForward       = Quaternion.LookRotation(cameraLookForwardVector);

            // Use the camera look direction to convert the input movement from camera space to world space
            _targetMovement = cameraLookForward * inputMovement* sl;
        }

        private void CheckForJump() {
            // Jump if the space bar was pressed this frame and we're not already jumping, trigger the jump
            if(isGrounded&& sl>0)
            {
            if (SimpleInput.GetButtonDown("Jump") && !_jumping)
                _jumpThisFrame = true;
                }
        }

        private void MovePlayer() {
            // Start with the current velocity
            Vector3 velocity = _rigidbody.velocity;

            // Smoothly animate towards the target movement velocity
            _movement = Vector3.Lerp(_movement, _targetMovement, Time.fixedDeltaTime * 5.0f);
            velocity.x = _movement.x;
            velocity.z = _movement.z;

            // Jump
            if (_jumpThisFrame) {
                // Instantaneously set the vertical velocity to 6.0 m/s
                velocity.y = 20.0f;

                // Mark the player as currently jumping and clear the jump input
                _jumping       = true;
                _jumpThisFrame = false;isGrounded=false;
                a.Play("Jump",0.334f);
            }

            // Reset jump after the apex
            if (_jumping && velocity.y < -0.1f)
                _jumping = false;

            // Set the velocity on the rigidbody
            _rigidbody.velocity = velocity;
        }

        // Rotate the character to face the direction we're moving. Lean towards the target movement direction.
        private void AnimateCharacter() {
            // Calculate the direction that the character is facing parallel to the ground plane
            Vector3    characterLocalForwardVector = _character.localRotation * Vector3.forward;
            Vector3    characterLookForwardVector  = ProjectVectorOntoGroundPlane(characterLocalForwardVector);
            Quaternion characterLookForward        = Quaternion.LookRotation(characterLookForwardVector);

            // Calculate the angle between the current movement direction and the target movement direction
            Vector3 targetMovementNormalized = _targetMovement.normalized;
            Vector3       movementNormalized =       _movement.normalized;
            float angle = targetMovementNormalized.sqrMagnitude > 0.0f ? SignedAngle2D(targetMovementNormalized, movementNormalized) : 0.0f;

            // Convert the delta between movement direction and the target movement direction to a lean amount. Clamp to +/- 45 degrees so the player doesn't lean too far.
            angle = angle * Mathf.Rad2Deg;
            angle = Mathf.Clamp(angle, -45.0f, 45.0f);

            // Convert the lean angle to a Quaternion that's oriented in the direction the character is facing
            Quaternion leanRotation = characterLookForward * Quaternion.Euler(0.0f, 0.0f, angle);

            // Rotate to face the direction of travel if we're moving forward
            Vector3 targetCharacterLookForwardVector = characterLookForwardVector;
            if (GetRigidbodyForwardVelocity(_rigidbody) >= 2.0f)
                targetCharacterLookForwardVector = _rigidbody.velocity.normalized;

            // Compose the target character rotation from the target look direction + target lean direction
            Quaternion targetRotation = Quaternion.LookRotation(targetCharacterLookForwardVector, leanRotation * Vector3.up);

            // Animate the character towards the target rotation
            _character.localRotation = Quaternion.Slerp(_character.localRotation, targetRotation, 5.0f * Time.fixedDeltaTime);
        }

        // Given a forward vector, get a y-axis rotation that points in the same direction that's parallel to the ground plane
        private static Vector3 ProjectVectorOntoGroundPlane(Vector3 vector) {
            Vector3 planeNormal = Vector3.up;
            Vector3.OrthoNormalize(ref planeNormal, ref vector);
            return vector;
        }

        // Get the rigidbody velocity along the ground plane
        private static float GetRigidbodyForwardVelocity(Rigidbody rigidbody) {
            Vector3 forwardVelocity = rigidbody.velocity;
            forwardVelocity.y = 0.0f;
            return forwardVelocity.magnitude;
        }
        void OnCollisionStay()

{
    isGrounded=true;
}
        // Get the difference between two angles along the ground plane
        private static float SignedAngle2D(Vector3 a, Vector3 b) {
            float angle = Mathf.Atan2(a.z, a.x) - Mathf.Atan2(b.z, b.x);
            if (angle <= -Mathf.PI) angle += 2.0f * Mathf.PI;
            if (angle >   Mathf.PI) angle -= 2.0f * Mathf.PI;
            return angle;
        }
    }

