using UnityEngine;

namespace Assets.Scripts
{
    public class Sounder : MonoBehaviour
    {
        [SerializeField] private AudioSource _audioSource;

        public virtual void Play()
        {
            _audioSource.Play();
        }
    }
}