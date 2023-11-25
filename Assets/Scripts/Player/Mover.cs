using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _step;
        [SerializeField] private float _maxHeight;
        [SerializeField] private float _minHeight;

        private Vector3 _targetPosition;

        private void Awake()
        {
            _targetPosition = transform.position;
        }

        private void Update()
        {
            if (transform.position != _targetPosition)
            {
                transform.position = Vector3.MoveTowards(
                    transform.position,
                    _targetPosition,
                    _speed * Time.deltaTime);
            }
        }

        public void TryMoveUp()
        {
            if (_targetPosition.y < _maxHeight)
                SetNextPosition(_step);
        }

        public void TryMoveDown()
        {
            if (_targetPosition.y > _minHeight)
                SetNextPosition(-_step);
        }

        private void SetNextPosition(float step)
        {
            _targetPosition = new Vector2(
                _targetPosition.x,
                _targetPosition.y + step);
        }
    }
}