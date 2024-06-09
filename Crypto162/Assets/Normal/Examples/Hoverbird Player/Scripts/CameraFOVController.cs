using UnityEngine;

public class CameraFOVController : MonoBehaviour
{
    public float fovSpeed = 5f; // Kecepatan perubahan FOV

    public Camera mainCamera;
    private float targetFOV;
    public GameObject nigger;
    void Start()
    {
        mainCamera = Camera.main;
        // Mendapatkan nilai jalan dari PlayerPrefs, jika tidak ada, maka defaultnya adalah 0
        int jalan = PlayerPrefs.GetInt("jalan");
        // Menentukan targetFOV berdasarkan nilai jalan
        targetFOV = (jalan == 1) ? 70f : 84f;
        // Set FOV awal
        mainCamera.fieldOfView = targetFOV;
    }

    void Update()
    {
        // Update nilai jalan
        int jalan = PlayerPrefs.GetInt("jalan");
        // Menentukan targetFOV berdasarkan nilai jalan
        targetFOV = (jalan == 1) ? 85f : 60f;
        if(jalan==1)
        {
            nigger.SetActive(true);
        }else{
            nigger.SetActive(false);
        }

        // Smooth perubahan FOV menggunakan Lerp
        mainCamera.fieldOfView = Mathf.Lerp(mainCamera.fieldOfView, targetFOV, fovSpeed * Time.deltaTime);
    }
}
