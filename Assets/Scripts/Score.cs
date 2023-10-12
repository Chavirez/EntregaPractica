using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public Text scoreTextCoin;
    public static int puntosCoin = 0;
    public AudioSource CoinClip;
    public GameObject pc;

    public float myVolume = 15.0f;

    void Start()
    {
        
    }

   
    void OnTriggerEnter(Collider other)
    {

        Destroy(pc);
        puntosCoin += 1;
        scoreTextCoin.GetComponent<Text>().text = puntosCoin.ToString();
        CoinClip.Play();

       


    }
}
