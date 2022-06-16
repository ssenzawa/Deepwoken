using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) //Looks for a collision from the object tagged "Player"
    {

        if (collision.gameObject.CompareTag("Player")) //Collision for the gameObject for when "Player" collides with such object.
        {
            CoinScore.coinScore += 1; //Adds + 1 score for every coin 'destroyed'
            Destroy(gameObject); //If the player tag is Player then destroy gameObject, in this case the coin
        }
    }
}
