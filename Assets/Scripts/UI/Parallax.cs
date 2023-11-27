using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Parallax : MonoBehaviour
    {
        [SerializeField] private RawImage _image;
        [SerializeField] private float _speed;
        [SerializeField] private bool IsVertical;
        [SerializeField] private bool IsHorizontal;

        private float _fadeTime;

        private void Update()
        {
            _fadeTime += _speed * Time.deltaTime;

            if (IsVertical) 
            { 
                _image.uvRect = new(_fadeTime, 0, 
                    _image.uvRect.width, 
                    _image.uvRect.height);
            }

            if (IsHorizontal)
            {
                _image.uvRect = new(0,_fadeTime,
                    _image.uvRect.width,
                    _image.uvRect.height);
            }
        }
    }
}