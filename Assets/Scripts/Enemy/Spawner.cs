using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField] private Enemy[] _enemies;
        [SerializeField] private float _secondsBetweenSpawn;
        [SerializeField] private Transform[] _spawnPoints;

        private float _time = 0;

        private int _indexFirstSpawnPoint = 0;
        private int _indexFirstEnemy = 0;

        private void Update()
        {
            _time += Time.deltaTime;

            if (_time >= _secondsBetweenSpawn)
            {
                _time = 0;

                CreateEnemy();
            }
        }

        private void CreateEnemy()
        {
            int spawnPoint = Random.Range(
                _indexFirstSpawnPoint,
                _spawnPoints.Length);

            int enemyIndex = Random.Range(
                _indexFirstEnemy,
                _enemies.Length);

            Instantiate(
                _enemies[enemyIndex].transform,
                _spawnPoints[spawnPoint]);
        }
    }
}