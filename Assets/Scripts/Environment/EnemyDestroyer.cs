using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Environment
{
    public class EnemyDestroyer : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent<Enemy>(out Enemy enemy))
            {
                //enemy
            }
        }
    }
}