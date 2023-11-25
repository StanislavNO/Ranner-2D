using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Attacker : MonoBehaviour, IAttacker
    {
        [SerializeField] private int _damage;

        int IAttacker.Attack()
        {
            return _damage;
        }
    }
}