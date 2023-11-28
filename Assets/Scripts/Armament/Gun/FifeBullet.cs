using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class FifeBullet : Bullet
    {
        [SerializeField] private int _damage;

        public override int Attack()
        {
            return _damage;
        }
    }
}