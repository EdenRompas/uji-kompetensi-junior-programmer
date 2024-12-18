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
        if (StateManager.Instance.State == State.Play)
        {
            if (_playerInput.Movement < 0)
            {
                _animator.SetBool("IsStrafeLeft", true);
                _animator.SetBool("IsStrafeRight", false);
                _animator.SetBool("IsAttack", false);
            }
            else if (_playerInput.Movement > 0)
            {
                _animator.SetBool("IsStrafeRight", true);
                _animator.SetBool("IsStrafeLeft", false);
                _animator.SetBool("IsAttack", false);
            }
            else
            {
                _animator.SetBool("IsStrafeRight", false);
                _animator.SetBool("IsStrafeLeft", false);
                _animator.SetBool("IsAttack", false);
            }

            if (_playerInput.IsAttack)
            {
                _animator.SetBool("IsAttack", true);
            }
        }
    }
}
