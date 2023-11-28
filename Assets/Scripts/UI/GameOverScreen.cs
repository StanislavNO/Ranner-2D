using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class GameOverScreen : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _gameOverGroup;

        private void Awake()
        {
            _gameOverGroup.alpha = 0;
        }

        public void Activate()
        {
            Time.timeScale = 0;
            _gameOverGroup.alpha = 1;
        }

        public void GetRestart(int sceneNumbers = 0)
        {
            SceneManager.LoadScene(sceneNumbers);
            Time.timeScale = 1;
        }

        public void GetExit()
        { 
            Application.Quit();
        }
    }
}