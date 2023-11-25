using System;
using System.Collections;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyLife : MonoBehaviour
    {
        [SerializeField] private int _life;

        private int _minLife;

        public float Point => _life;

        private void Awake()
        {
            _life = 0;
        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent<IAttacker>(out IAttacker damager))
                SetDamage(damager);
        }

        private void SetDamage(IAttacker damager)
        {
            int damage = damager.Attack();
            _life -= damage;

            if (_life <= _minLife)
                Die();
        }

        private void Die()
        {
            Debug.Log("Die");
        }
    }
}