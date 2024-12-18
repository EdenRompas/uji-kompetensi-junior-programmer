using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacking : MonoBehaviour
{
    [SerializeField] private SO_Player _playerSO;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(_playerSO.ProjectileSO.Prefab, transform.position, Quaternion.identity);
        }
    }
}
