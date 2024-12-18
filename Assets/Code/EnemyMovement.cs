using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private SO_Enemy _enemySO;

    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * _enemySO.Speed);
    }
}
