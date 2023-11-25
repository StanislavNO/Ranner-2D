using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class PlayerInput : MonoBehaviour
    {
        [SerializeField] private Mover _mover;

        private void Update()
        {
            if (Input.GetKey(KeyCode.W))
                _mover.TryMoveUp();

            if (Input.GetKey(KeyCode.S))
                _mover.TryMoveDown();
        }
    }
}