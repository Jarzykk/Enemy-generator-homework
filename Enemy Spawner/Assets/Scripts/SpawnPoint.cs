using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject _enemyTemplate;

    private Transform _spawnPointPosition;

    private void Start()
    {
        _spawnPointPosition = GetComponent<Transform>();
    }

    public void SpawnEnemy()
    {
        Instantiate(_enemyTemplate, _spawnPointPosition.position, Quaternion.identity);
    }
}
