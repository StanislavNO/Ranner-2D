using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyMover : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private void Update()
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
    }
}