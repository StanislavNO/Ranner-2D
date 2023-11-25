using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Assets.Scripts
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private UnityEvent LivesAreOver;
        [SerializeField] private int _point;

        public int LivePoint { get; private set; }

        private void Awake()
        {
            LivePoint = _point;
        }

        public void SetDamage(int damage)
        {
            if (damage > 0)
                LivePoint -= damage;

            if (LivePoint <= 0)
                LivesAreOver.Invoke();
        }
    }
}