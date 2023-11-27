using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Spawner : ObjectPool
    {
        [SerializeField] private Enemy[] _enemies;
        [SerializeField] private float _secondsBetweenSpawn;
        [SerializeField] private Transform[] _spawnPoints;

        private float _time = 0;

        private int _indexFirstSpawnPoint = 0;
        private int _indexFirstEnemy = 0;

        private void Start()
        {
            CreateEnemy(Capacity);
        }

        private void Update()
        {
            _time += Time.deltaTime;

            if (_time >= _secondsBetweenSpawn)
            {
                if (TryGetObject(out GameObject enemy))
                {
                    _time = 0;

                    int spawnPoint = Random.Range(
                        _indexFirstSpawnPoint,
                        _spawnPoints.Length);

                    SetEnemy(enemy, _spawnPoints[spawnPoint].position);
                }
                else
                    CreateEnemy();

            }
        }

        private void SetEnemy(GameObject enemy, Vector3 spawnPoint)
        {
            enemy.SetActive(true);
            enemy.transform.position = spawnPoint;
        }

        private void CreateEnemy(int numberEnemies = 1)
        {
            int enemyIndex;

            for (int i = 0; i < numberEnemies; i++)
            {
                enemyIndex = Random.Range(
                    _indexFirstEnemy,
                    _enemies.Length);
                Debug.Log(enemyIndex);

                Initialize(_enemies[enemyIndex].gameObject);
            }
        }
    }
}