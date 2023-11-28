using UnityEngine;

namespace Assets.Scripts
{
    [RequireComponent(typeof(Rigidbody2D),typeof(Collider2D))]
    public abstract class Bullet : MonoBehaviour , IAttacker
    {
        [SerializeField] private float _speed;

        private Rigidbody2D _rigidBody;

        protected void Awake()
        {
            _rigidBody = GetComponent<Rigidbody2D>();
        }

        protected void LateUpdate()
        {
            _rigidBody.AddForce(
                Vector2.right * _speed, 
                ForceMode2D.Impulse);
        }

        public abstract int Attack();
    }
}