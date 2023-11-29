using UnityEngine;

namespace Assets.Scripts
{
    public class Medicament : MonoBehaviour
    {
        [SerializeField] private int _power;

        public int Power { get; private set; }

        private void Awake()
        {
            Power = _power;
        }
    }
}