using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    // Function to load the Game Scene
    public void PlayGame()
    {
        SceneManager.LoadScene("LaneScape");
    }

    // Function to load the Instructions Scene
    public void ShowInstructions()
    {
        SceneManager.LoadScene("InstructionsScene");
    }

    // Function to open GitHub link
    public void OpenGitHub()
    {
        Application.OpenURL("https://github.com/alexintmult/LaneScape_IMM");
    }
    
    public void BackToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
