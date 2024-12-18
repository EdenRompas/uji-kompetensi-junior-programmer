using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacking : MonoBehaviour
{
    [SerializeField] private SO_Player _playerSO;
    [SerializeField] private PlayerInput _playerInput;
    [SerializeField] private Transform _spawnPoint;

    private float _timer;

    private void Update()
    {
        if (StateManager.Instance.State == State.Play)
        {
            _timer -= Time.deltaTime;

            if (_timer < 0)
            {
                if (_playerInput.IsAttack)
                {
                    Instantiate(_playerSO.ProjectileSO.Prefab, _spawnPoint.position, Quaternion.identity);
                    _timer = _playerSO.AttackRemeaning;
                }
            }
        }
    }
}
