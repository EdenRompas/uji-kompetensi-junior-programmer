using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Entity
{
    [SerializeField] private SO_Player _playerSO;
    [SerializeField] private PlayerInput _playerInput;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(_playerInput.Horizontal, 0, 0) * Time.deltaTime * _playerSO.Speed);
    }
}
