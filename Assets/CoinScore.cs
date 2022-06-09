using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinScore : MonoBehaviour
{
    Text coin;
    public static int coinScore;
    void Start()
    {
        coin = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        coin.text = coinScore.ToString();
    }
}
