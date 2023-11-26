using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Parallax : MonoBehaviour
    {
        [SerializeField] private RawImage _image;
        [SerializeField] private float _speed;

        private float _fadeTime;

        private void Update()
        {
            _fadeTime += _speed * Time.deltaTime;
            _image.uvRect = new(_fadeTime,0,_image.uvRect.width, _image.uvRect.height);
        }
    }
}