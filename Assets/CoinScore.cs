using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinScore : MonoBehaviour
{
    Text coin; //Text box for storing the score
    public static int coinScore; //Establishes the int coinScore
    void Start()
    {
        coin = GetComponent<Text>(); //Gets our text that our coin uses e.g the score
    }

    void Update()
    {
        coin.text = coinScore.ToString(); //Creates a ToString for our coin text and coin score
    }
}
