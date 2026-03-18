using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenTransition : MonoBehaviour
{
    public void LoadGameplayScene()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void LoadMainMenuScene() 
    {
        SceneManager.LoadScene("MainMenu");
    }

}
