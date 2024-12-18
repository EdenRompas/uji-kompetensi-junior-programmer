using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _timerText;

    private void Start()
    {
        StateManager.Instance.OnTimerChange += UpdateTimer;
    }

    private void UpdateTimer(float time)
    {
        _timerText.text = Mathf.RoundToInt(time).ToString();
    }
}
