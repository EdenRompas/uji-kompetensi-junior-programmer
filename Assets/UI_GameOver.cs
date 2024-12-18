using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_GameOver : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;

    private void Start()
    {
        ScoreManager.Instance.OnScoreChange += UpdateScore;
    }

    private void UpdateScore(int score)
    {
        _scoreText.text = score.ToString();
    }

    public void PlayAgainButton()
    {
        GameManager.Instance.PlayAgain();
    }

    public void MainMenuButton()
    {
        GameManager.Instance.MainMenu();
    }
}
