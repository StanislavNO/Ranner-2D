using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
    public class EnemyLife : MonoBehaviour
    {
        [SerializeField] private int _life;
        [SerializeField] private UnityEvent _livesAreOver;

        private int _minLife;

        public float Point => _life;

        private void Awake()
        {
            _minLife = 0;
        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out IAttacker damager))
                SetDamage(damager);

            if (collision.TryGetComponent(out Player _))
                Die();
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
            _livesAreOver?.Invoke();
            gameObject.SetActive(false);
        }
    }
}