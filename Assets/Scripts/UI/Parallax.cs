using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Parallax : MonoBehaviour
    {
        [SerializeField] private RawImage _image;
        [SerializeField] private float _speed;
        [SerializeField] private bool _isVertical;
        [SerializeField] private bool _isHorizontal;

        private float _fadeTime;

        private void Update()
        {
            _fadeTime += _speed * Time.deltaTime;

            if (_isVertical)
            {
                _image.uvRect = new(
                    0,
                    _fadeTime,
                    _image.uvRect.width,
                    _image.uvRect.height);
            }

            if (_isHorizontal)
            {
                _image.uvRect = new(
                    _fadeTime,
                    0,
                    _image.uvRect.width,
                    _image.uvRect.height);
            }
        }
    }
}