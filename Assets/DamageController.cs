using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour
{
    [SerializeField] private int playerDamage; //Integer for player damage so the hearts go down

    [SerializeField] private HealthController _healthController; //Health Controller for setting the health of the player, their HP 

    private void OnTriggerEnter2D(Collider2D collision) //Collision for the object and a trigger
    {
        if (collision.CompareTag("Player"))
        {
            Damage(); //'Damages' the player, used for when the player runs into the enemy
        }
    }

    void Damage() //Script for Damage
    {
        _healthController.playerHealth = _healthController.playerHealth - playerDamage; //Sets the player health at -1 hearts from max health (3)
        _healthController.UpdateHealth(); //Updates health
        gameObject.SetActive(false); //Makes the gameobject that our player comes into contact with dissapear
    }
}
