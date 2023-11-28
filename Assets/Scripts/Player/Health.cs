using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private UnityEvent _livesAreOver;
        [SerializeField] private UnityEvent _healthChanged;

        [SerializeField] private int _point;
        [SerializeField] private bool _isHealing;

        public int MaxPoint { get; private set; }
        public int LivePoint { get; private set; }

        private void Awake()
        {
            MaxPoint = _point;
            LivePoint = _point;
        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent<IAttacker>(out IAttacker attacker))
            {
                SetDamage(attacker.Attack());
            }

            if (collision.TryGetComponent<Medicament>(out Medicament medicament)
                && _isHealing)
            {
                AddLivePoints(medicament.Power);
                Destroy(medicament.gameObject);
            }
        }

        private void AddLivePoints(int value)
        {
            if (value >= uint.MinValue)
            {
                if (value + LivePoint <= MaxPoint)
                    LivePoint += value;
                else
                    LivePoint = MaxPoint;

                _healthChanged.Invoke();
            }
        }

        private void SetDamage(int damage)
        {
            if (damage > uint.MinValue)
                LivePoint -= damage;

            if (LivePoint <= uint.MinValue)
                _livesAreOver.Invoke();

            if(_isHealing)
                Debug.Log("plaer " + LivePoint);

            _healthChanged.Invoke();
        }
    }
}