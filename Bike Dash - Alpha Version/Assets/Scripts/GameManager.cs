using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject winText;
    public GameObject gameOverText;
    private bool gameEnded = false;

    // Call this when the player wins
    public void WinGame()
    {
        if (!gameEnded)
        {
            winText.SetActive(true);
            gameEnded = true;
        }
    }

    // Call this when the player loses
    public void GameOver()
    {
        if (!gameEnded)
        {
            gameOverText.SetActive(true);
            gameEnded = true;
        }
    }
}