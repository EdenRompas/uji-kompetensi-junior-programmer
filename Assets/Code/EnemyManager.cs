using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EnemyData
{
    public SO_Enemy EnemySO;
}

public class EnemyManager : MonoBehaviour
{
    [SerializeField] private List<EnemyData> _enemyDatas = new List<EnemyData>();

    [SerializeField] private float _minWidth;
    [SerializeField] private float _maxWidth;
    [SerializeField] private float _spawnPoint;

    [SerializeField] private int _spawnRate;
    [SerializeField] private float _remeaningTime;

    private float _timer;

    private void Start()
    {
        _timer = _spawnRate;
    }

    private void Update()
    {
        _timer -= Time.deltaTime;

        if (_timer < 0)
        {
            int randomEnemy = UnityEngine.Random.Range(0, _enemyDatas.Count);

            float randomWidth = UnityEngine.Random.Range(_minWidth, _maxWidth);

            GameObject enemy = _enemyDatas[randomEnemy].EnemySO.Prefab;
            Vector3 point = new Vector3(randomWidth, 0, _spawnPoint);

            Instantiate(enemy, point, Quaternion.identity);

            _timer = _spawnRate;
        }
    }
}
