using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        Instance = this;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Gameplay");
    }
}
