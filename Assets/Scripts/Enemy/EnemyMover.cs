using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyMover : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private void Update()
        {
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
        }
    }
}