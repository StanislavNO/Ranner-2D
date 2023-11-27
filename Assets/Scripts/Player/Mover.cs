using UnityEngine;

namespace Assets.Scripts
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _step;
        [SerializeField] private float _maxHeightVertical;
        [SerializeField] private float _minHeightVertical;
        [SerializeField] private float _maxHeightHorizontal;
        [SerializeField] private float _minHeightHorizontal;

        private Vector3 _targetPosition;
        private Vector3 _startPosition;

        public bool IsVerticalStep { get; private set; }
        public bool IsHorizontalStep { get; private set; }

        private void Awake()
        {
            _targetPosition = transform.position;
            _startPosition = transform.position;
        }

        private void Update()
        {
            if (transform.position == _startPosition)
                ActivateAxes();
        }

        private void FixedUpdate()
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
            if (_targetPosition.y < _maxHeightVertical && IsVerticalStep)
            {
                IsHorizontalStep = false;
                SetNextPosition(_step);
            }
        }

        public void TryMoveDown()
        {
            if (_targetPosition.y > _minHeightVertical && IsVerticalStep)
            {
                IsHorizontalStep = false;
                SetNextPosition(-_step);
            }
        }

        public void TryMoveLeft()
        {
            if (_targetPosition.x > _minHeightHorizontal && IsHorizontalStep)
            {
                IsVerticalStep = false;
                SetNextPosition(-_step);
            }
        }

        public void TryMoveRight()
        {
            if (_targetPosition.x < _maxHeightHorizontal && IsHorizontalStep)
            {
                IsVerticalStep = false;
                SetNextPosition(_step);
            }
        }

        private void ActivateAxes()
        {
            IsHorizontalStep = true;
            IsVerticalStep = true;
        }

        private void SetNextPosition(float step)
        {
            if (IsVerticalStep)
            {
                _targetPosition = new Vector2(
                    _targetPosition.x,
                    _targetPosition.y + step);
            }

            if (IsHorizontalStep)
            {
                _targetPosition = new Vector2(
                    _targetPosition.x + step,
                    _targetPosition.y);
            }
        }
    }
}