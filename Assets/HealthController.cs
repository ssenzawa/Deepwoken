using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public int playerHealth; //Integer for player health

    [SerializeField] private Image[] hearts; //Establishes the image of the hearts displayed

    private void Start()
    {
        UpdateHealth(); //Used for updating the player health
    }

    public void UpdateHealth()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if  (i < playerHealth)
            {
                hearts[i].color = Color.red; //Sets the hearts red 
            }
            else
            {
                hearts[i].color = Color.black; //Sets the hearts colour black when the health 'goes down'
            }
        }
    }
}
