using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_MainMenu : MonoBehaviour
{
    public void PlayGameButton()
    {
        MainMenuManager.Instance.PlayGame();
    }
}
