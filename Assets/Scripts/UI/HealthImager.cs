using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class HealthImager : MonoBehaviour
    {
        [SerializeField] private Health _health;
        [SerializeField] private Gradient _healthGradient;
        [SerializeField] private Image _healthImage;

        private void Awake()
        {
            _healthImage.fillAmount = 1;
        }

        public void OnHealthChange()
        {
            float healthNormalize = 
                _health.LivePoint / 
                (_health.MaxPoint / 100.0f) 
                / 100.0f;

            _healthImage.fillAmount = healthNormalize;
            _healthImage.color = _healthGradient.Evaluate(healthNormalize);
        }
    }
}