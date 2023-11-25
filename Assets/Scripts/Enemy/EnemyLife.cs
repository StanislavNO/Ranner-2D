using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyLife : MonoBehaviour
    {
        [SerializeField] private int _life;

        private void SetDamage(IAttacker damager)
        {
            int damage = damager.Attack();
            _life -= damage;
        }
    }
}