using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public abstract class Armament : MonoBehaviour , IAttacker
    {
        [SerializeField] protected int Damage;

        public abstract int Attack();
    }
}