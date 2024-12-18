using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public static StateManager Instance { get; private set; }

    public Action OnEndTime;
    public Action OnStartTime;
    public Action<float> OnTimerChange;

    [SerializeField] private SO_GameState _gameStateSO;

    private float _timer;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _timer = _gameStateSO.Duration;
    }

    // Update is called once per frame
    void Update()
    {
        _timer -= Time.deltaTime;
        OnTimerChange?.Invoke(_timer);

        if (_timer < 0)
        {
            OnEndTime?.Invoke();
        }
    }
}
