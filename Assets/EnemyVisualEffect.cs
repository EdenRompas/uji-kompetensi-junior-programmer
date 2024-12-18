using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVisualEffect : MonoBehaviour
{
    [SerializeField] private GameObject _particleEffect;
    [SerializeField] private EnemyCollide _enemyCollide;

    private void Start()
    {
        _enemyCollide.OnDeath += PlayEffect;
    }

    private void OnDisable()
    {
        _enemyCollide.OnDeath -= PlayEffect;
    }

    private void PlayEffect()
    {
        Instantiate(_particleEffect, transform.position, Quaternion.identity);
    }
}
