using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class GameOverScreen : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _gameOverGroup;
        [SerializeField] private Button _restart;
        [SerializeField] private Button _exit;

        private void Awake()
        {
            _gameOverGroup.alpha = 0;
        }

        public void Activate()
        {
            Time.timeScale = 0;
            _gameOverGroup.alpha = 1;
        }
    }
}