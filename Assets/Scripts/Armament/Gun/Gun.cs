using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Gun : Armament
    {
        public override int Attack()
        {
            return Damage;
        }
    }
}