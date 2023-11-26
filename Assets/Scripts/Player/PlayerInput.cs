using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private Mover _mover;

        private void FixedUpdate()
        {
            if (Input.GetKey(KeyCode.W))
                _mover.TryMoveUp();

            if (Input.GetKey(KeyCode.S))
                _mover.TryMoveDown();

            if (Input.GetKey(KeyCode.A))
                _mover.TryMoveLeft();

            if (Input.GetKey(KeyCode.D))
                _mover.TryMoveRight();
        }
    }
}