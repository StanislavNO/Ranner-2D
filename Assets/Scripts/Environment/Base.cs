using UnityEngine;

namespace Assets.Scripts
{
    public class Base : MonoBehaviour, IAttacker
    {
        private int _damage = 1000;

        public int Attack()
        {
            return _damage;
        }
    }
}