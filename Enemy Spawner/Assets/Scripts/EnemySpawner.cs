using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private float _secondsToSpawnEnemy;

    private float _spawnSecondsCount = 0;
    private int _numberOfCurrentSpawnPoint = 0;
    private SpawnPoint[] _spawnPoints;

    private void Start()
    {
        _spawnPoints = new SpawnPoint[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            _spawnPoints[i] = transform.GetChild(i).GetComponent<SpawnPoint>();
        }
    }

    private void Update()
    {
        _spawnSecondsCount += Time.deltaTime;

        if (_spawnSecondsCount >= _secondsToSpawnEnemy)
        {
            _spawnSecondsCount = 0;
            _spawnPoints[_numberOfCurrentSpawnPoint].SpawnEnemy();
            _numberOfCurrentSpawnPoint++;

            if (_numberOfCurrentSpawnPoint == _spawnPoints.Length)
                _numberOfCurrentSpawnPoint = 0;
        }

        Debug.Log(_numberOfCurrentSpawnPoint);
    }
}
