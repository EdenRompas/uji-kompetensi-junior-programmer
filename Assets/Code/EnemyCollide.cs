using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollide : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        ScoreManager.Instance.RemoveScore();
    }
}
