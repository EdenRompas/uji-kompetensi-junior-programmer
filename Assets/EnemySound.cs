using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySound : MonoBehaviour
{
    [SerializeField] private AudioClip _deathClip;
    [SerializeField] private EnemyCollide _enemyCollide;

    private void Start()
    {
        _enemyCollide.OnDeath += PlayDeathSound;
    }

    private void PlayDeathSound()
    {
        SFXManager.Instance.PlaySound(_deathClip);
    }
}
