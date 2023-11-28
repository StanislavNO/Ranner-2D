using UnityEngine;
using TMPro;

namespace Assets.Scripts
{
    public class HealthBar : MonoBehaviour
    {
        [SerializeField] private Health _health;
        [SerializeField] private TMP_Text _text;

        private void Awake()
        {
            ChangedHealth();
        }

        public void ChangedHealth()
        {
            _text.text = $"{_health.LivePoint}";
        }
    }
}