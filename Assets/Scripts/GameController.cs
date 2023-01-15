using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Instance { get; private set; }

    private int score = 0;
    private int playerLives = 3;

    private void Awake() 
    { 
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }

    public void IncreaseScore()
    {
        Debug.Log($"{++GameController.Instance.score} points");
    }

    public void DecreasePlayerLives()
    {
        GameController.Instance.playerLives--;
        if(GameController.Instance.playerLives < 1)
        {
            Debug.Log("Game over. No lives left");
        }
        else
        {
            Debug.Log($"{GameController.Instance.playerLives} lives");
        }
    }
}