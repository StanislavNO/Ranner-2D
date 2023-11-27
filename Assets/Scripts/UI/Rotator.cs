using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private float _rotation;

        private void Update()
        {
            _rotation += Time.deltaTime * _speed;

            transform.rotation = Quaternion.Euler(
                transform.rotation.x,
                transform.rotation.y,
                _rotation);
        }
    }
}