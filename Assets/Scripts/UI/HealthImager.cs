﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.UI
{
    public class HealthImager : MonoBehaviour
    {
        [SerializeField] private Health health;
        [SerializeField] private Gradient _healthGradient;
        [SerializeField] private Image _healthImage;

        private void Awake()
        {
            _healthImage.fillAmount = 1;
        }

        public void OnHealthChange()
        {
            Debug.Log(health.MaxPoint + " " + health.LivePoint);
            float healthNormalize = 
                health.LivePoint / 
                (health.MaxPoint / 100.0f) 
                / 100.0f;
            Debug.Log(healthNormalize);
            _healthImage.fillAmount = healthNormalize;
            _healthImage.color = _healthGradient.Evaluate(healthNormalize);
        }
    }
}