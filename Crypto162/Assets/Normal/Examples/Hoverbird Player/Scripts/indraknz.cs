using UnityEngine;

public class indraknz : MonoBehaviour
{
    public float moveSpeed = 3f;  // Kecepatan gerak AI
    public float minJumpForce = 5f;  // Kekuatan lompat minimum
    public float maxJumpForce = 10f;  // Kekuatan lompat maksimum
    public float minJumpInterval = 2f;  // Interval minimum untuk lompat
    public float maxJumpInterval = 5f;  // Interval maksimum untuk lompat

    private Rigidbody rb;  // Komponen Rigidbody AI
    private GameObject player;  // Referensi ke objek dengan tag "Player"
    private float nextJumpTime;
    Vector3 randomDirection;
    Vector3 randomPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        SetNextJumpTime();
        SetRandomPosition();
        Invoke("sipu", Random.Range(2, 4));
    }

    void sipu()
    {
        randomDirection = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f));
        Invoke("sipu", Random.Range(2, 4));
    }

    void OnCollisionEnter(Collision other)
    {
        CancelInvoke("sipu");
        sipu();
    }

    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        // Gerakan AI secara random ke posisi acak yang telah ditentukan
        transform.position = Vector3.MoveTowards(transform.position, randomPosition, moveSpeed * Time.deltaTime);

        // Jika AI sudah mencapai posisi acak, tentukan posisi acak baru
        if (Vector3.Distance(transform.position, randomPosition) < 0.1f)
        {
            SetRandomPosition();
        }

        // AI selalu lookAt ke player
        if (player != null)
        {
            Vector3 direction = player.transform.position - transform.position;
            direction.y = 0; // Keep the y component zero to constrain rotation around the Y-axis
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = rotation;
        }

        // Lompat pada interval acak
        if (Time.time >= nextJumpTime)
        {
            Jump();
            SetNextJumpTime();
        }
    }

    void Jump()
    {
        float jumpForce = Random.Range(minJumpForce, maxJumpForce);
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    void SetNextJumpTime()
    {
        nextJumpTime = Time.time + Random.Range(minJumpInterval, maxJumpInterval);
    }

    void SetRandomPosition()
    {
        float randomX = Random.Range(-55f, 55f);
        float randomZ = Random.Range(-66f, 66f);
        randomPosition = new Vector3(randomX, transform.position.y, randomZ);
    }
}
