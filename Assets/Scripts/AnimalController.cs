using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalController : MonoBehaviour
{
    [SerializeField] private HungerBar hungerBar;
    [SerializeField] private int maxHungerStatus = 3;

    private int currentHungerStatus = 0;

    void Start()
    {
        hungerBar.SetMaxHungerStatus(maxHungerStatus);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Food")
        {
            EatFood();
            Destroy(other.gameObject);

            if(currentHungerStatus == maxHungerStatus)
            {
                GameController.Instance.IncreaseScore();
                Destroy(gameObject);
            }  
        }

        if(other.gameObject.tag == "Player")
        {
            GameController.Instance.DecreasePlayerLives();
        }
    }

    private void EatFood()
    {
        hungerBar.SetHungerStatus(++currentHungerStatus);
    }
}