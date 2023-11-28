using UnityEngine;

namespace Assets.Scripts.Environment
{
    [RequireComponent(typeof(Collider2D))]
    public class Destroyer : MonoBehaviour
    {
        private Collider2D _collider;

        private void Awake()
        {
            _collider = GetComponent<Collider2D>();
            _collider.isTrigger = true;
        }

        public void OnTriggerEnter2D(Collider2D collision)
        {
            Destroy(_collider.gameObject);
        }
    }
}