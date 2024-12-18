using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollide : MonoBehaviour
{
    public Action OnDeath;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.GetComponentInParent<Entity>() != null)
        {
            if (collision.transform.GetComponentInParent<Entity>().EntityData == EntityData.Player)
            {
                ScoreManager.Instance.RemoveScore();
            }

            if (collision.transform.GetComponentInParent<Entity>().EntityData == EntityData.Projectile)
            {
                ScoreManager.Instance.AddScore();
                OnDeath?.Invoke();
            }

            if (collision.transform.GetComponentInParent<Entity>().EntityData == EntityData.Blocker)
            {
                ScoreManager.Instance.RemoveScore();
            }

            Destroy(gameObject);
        }
    }
}
