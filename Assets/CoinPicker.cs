using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            CoinScore.coinScore += 1;
            Destroy(gameObject);
        }
    }
}
