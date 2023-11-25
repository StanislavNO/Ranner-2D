using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(EnemyLife))]
    public abstract class Enemy : MonoBehaviour, IAttacker
    {
        [SerializeField] protected int Damage;

        public int Attack()
        {
            return Damage;
        }
    }
}