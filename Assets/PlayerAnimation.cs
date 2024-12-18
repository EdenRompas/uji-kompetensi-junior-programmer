using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private PlayerInput _playerInput;

    // Update is called once per frame
    void Update()
    {
        if (_playerInput.Horizontal < 0)
        {
            _animator.SetBool("IsStrafeLeft", true);
            _animator.SetBool("IsStrafeRight", false);
        }
        else if (_playerInput.Horizontal > 0)
        {
            _animator.SetBool("IsStrafeRight", true);
            _animator.SetBool("IsStrafeLeft", false);
        }
        else
        {
            _animator.SetBool("IsStrafeRight", false);
            _animator.SetBool("IsStrafeLeft", false);
        }
    }
}
