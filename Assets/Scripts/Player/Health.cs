﻿using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private UnityEvent LivesAreOver;
        [SerializeField] private UnityEvent _healthChanged;
        [SerializeField] private int _point;

        public int LivePoint { get; private set; }

        private void Awake()
        {
            LivePoint = _point;
        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent<IAttacker>(out IAttacker attacker))
                SetDamage(attacker.Attack());
        }

        public void SetDamage(int damage)
        {
            if (damage > 0)
                LivePoint -= damage;

            if (LivePoint <= 0)
                LivesAreOver.Invoke();

            _healthChanged.Invoke();
        }
    }
}