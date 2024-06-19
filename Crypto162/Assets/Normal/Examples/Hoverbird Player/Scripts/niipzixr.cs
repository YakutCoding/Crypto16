using UnityEngine;
using TMPro;

public class niipzixr : MonoBehaviour
{
    public TextMeshProUGUI shiudfhsifhisa;
    public GameObject adfjioas;
    public float zxcvnqwe = 5f;

    public float qwertyasdf;
    public string[] ghjklzxc;
    private bool bnmqwert;
    public float[] anjo;

    void Start()
    {
        shiudfhsifhisa.text = "";
        adfjioas.SetActive(false);
        bnmqwert = false;
        zxcvnqwe = anjo[PlayerPrefs.GetInt("hro")];        qwertyasdf = anjo[PlayerPrefs.GetInt("hro")];
    }

    void Update()
    {
        if (bnmqwert)
        {
            qwertyasdf -= Time.deltaTime;
            shiudfhsifhisa.text = Mathf.Ceil(qwertyasdf).ToString();

            if (qwertyasdf <= 0)
            {
                zxcasdqwe();
            }
        }

        foreach(string poiuytrew in ghjklzxc)
        {
            if (SimpleInput.GetButtonDown(poiuytrew))
            {
                asdfghjkl();
            }
        }
    }

    public void asdfghjkl()
    {
        if (!bnmqwert)
        {
            qwertyasdf = zxcvnqwe;
            adfjioas.SetActive(true);
            bnmqwert = true;
        }
    }

    private void zxcasdqwe()
    {
        shiudfhsifhisa.text = "";
        adfjioas.SetActive(false);
        bnmqwert = false;
    }
}
