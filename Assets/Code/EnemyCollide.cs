using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollide : MonoBehaviour
{
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
            }

            Destroy(gameObject);
        }
    }
}
