using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_GameState : MonoBehaviour
{
    [SerializeField] private GameObject _gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        StateManager.Instance.OnEndTime += GameOver;
    }

    private void GameOver()
    {
        _gameOverPanel.SetActive(true);
    }
}
