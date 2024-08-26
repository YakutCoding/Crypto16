using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
public class zkvkwa : MonoBehaviour
{
    public int Zkvkwa;
    public float GameTimer;
    public float CoinCryptoCurrency;
    public GameObject coinCryptoObjecttOKEN;
    public bool isd;
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
            Zkvkwa+=(int)CoinCryptoCurrency;//Game time depends on CoinCrypto
            if(coinCryptoObjecttOKEN!=null)
            {
            Realtime.Destroy(coinCryptoObjecttOKEN);
            Destroy(coinCryptoObjecttOKEN);
            }
        }

    }
    void OnTriggerEnter(Collider otehr)
    {
      
    }
}
