using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zkvkwa : MonoBehaviour
{
    public int Zkvkwa;
    public float GameTimer;
    public float CoinCryptoCurrency;
    // Start is called before the first frame update
    void Start()
    {
        CoinCryptoCurrency=PlayerPrefs.GetInt("CoinsCryptoWallet");
    }

    // Update is called once per frame
    void Update()
    {
        //ZKvkwa is Game Timer helper
        if(Zkvkwa>80)
        {
            Destroy(gameObject);
        }
    }
}
