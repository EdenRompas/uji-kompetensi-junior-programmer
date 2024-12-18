using System;
using UnityEngine;

public enum State
{
    Play,
    Pause,
    GameOver,
}

public class StateManager : MonoBehaviour
{
    public static StateManager Instance { get; private set; }

    public Action OnEndTime;
    public Action OnStartTime;
    public Action<float> OnTimerChange;

    [SerializeField] private GameOverState _gameOverState;

    public State State { get; private set; }

    [SerializeField] private SO_GameState _gameStateSO;

    private float _timer;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        State = State.Play;
        _timer = _gameStateSO.Duration;
    }

    void Update()
    {
        if (State == State.Play)
        {
            _timer -= Time.deltaTime;
            OnTimerChange?.Invoke(_timer);

            if (_timer < 1)
            {
                _gameOverState.Enter();
                State = State.GameOver;
                OnEndTime?.Invoke();
            }
        }
    }
}
