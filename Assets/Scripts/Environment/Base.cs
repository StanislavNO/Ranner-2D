using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Base : MonoBehaviour
    {
        [SerializeField] private int _health;

        public int Health => _health;

        public void OnTriggerEnter2D(Collider2D collision)
        {
            Debug.Log("triger");
            if (collision.TryGetComponent<IAttacker>(out IAttacker attacker))
                SetDamage(attacker);
        }

        private void SetDamage( IAttacker attacker)
        {
            int damage = attacker.Attack();
            if (damage > 0)
                _health -= damage;

            Debug.Log("set");
        }
    }
}