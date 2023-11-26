using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Base : MonoBehaviour, IAttacker
    {
        //[SerializeField] private int _health;

        private int _damage = 1000;

        //public int Health => _health;

        //public void OnTriggerEnter2D(Collider2D collision)
        //{
        //    if (collision.TryGetComponent<IAttacker>(out IAttacker attacker))
        //        SetDamage(attacker);
        //}

        public int Attack()
        {
            return _damage;
        }

        //private void SetDamage( IAttacker attacker)
        //{
        //    int damage = attacker.Attack();
        //    if (damage > 0)
        //        _health -= damage;
        //}
    }
}