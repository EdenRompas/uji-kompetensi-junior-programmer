using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ScoreData
{
    public int Score;
}

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    public Action<int> OnScoreChange;

    [SerializeField] private ScoreData _scoreData;

    private void Awake()
    {
        Instance = this;
    }

    public void AddScore()
    {
        _scoreData.Score += 1;
        OnScoreChange?.Invoke(_scoreData.Score);
    }

    public void RemoveScore()
    {
        if (_scoreData.Score > 0)
        {
            _scoreData.Score -= 3;
            OnScoreChange?.Invoke(_scoreData.Score);
        }
    }
}
