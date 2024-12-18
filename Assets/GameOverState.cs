using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverState : MonoBehaviour
{
    [SerializeField] private Animator _playerAnimator;
    [SerializeField] private GameObject _gameOverCamera;
    [SerializeField] private GameObject _mainCamera;

    public void Enter()
    {
        _gameOverCamera.SetActive(true);
        _mainCamera.SetActive(false);

        _playerAnimator.SetBool("IsDancing", true);
        _playerAnimator.SetBool("IsStrafeLeft", false);
        _playerAnimator.SetBool("IsStrafeRight", false);
        _playerAnimator.SetBool("IsAttack", false);
    }
}
