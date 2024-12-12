using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0; // Score tracker

    // Method to add to the score
    public void AddScore(int value)
    {
        score += value; // Increment score
        UpdateScoreUI(); // Update the UI
    }

    // Updates the UI with the latest score
    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
        else
        {
            Debug.LogError("ScoreText is not assigned in ScoreManager!");
        }
    }
}
