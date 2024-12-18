using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacking : MonoBehaviour
{
    [SerializeField] private SO_Player _playerSO;

    private float _timer;

    private void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer < 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(_playerSO.ProjectileSO.Prefab, transform.position, Quaternion.identity);
                _timer = _playerSO.AttackRemeaning;
            }
        }
    }
}
