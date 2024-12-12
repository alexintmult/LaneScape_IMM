using UnityEngine;

public class CarController : MonoBehaviour
{
    public ScoreManager scoreManager; // Reference to the ScoreManager

    void OnTriggerEnter(Collider other)
    {
        // Check if the object is tagged as "Diamond"
        if (other.CompareTag("Diamond"))
        {
            // Call AddScore on the ScoreManager
            if (scoreManager != null)
            {
                scoreManager.AddScore(1); // Increment the score by 1
            }
            else
            {
                Debug.LogError("ScoreManager is not assigned in CarController!");
            }

            // Destroy the diamond
            Destroy(other.gameObject);
        }
    }
}
