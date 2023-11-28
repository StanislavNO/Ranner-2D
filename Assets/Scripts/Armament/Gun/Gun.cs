using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class Gun : Armament
    {
        [SerializeField] private Bullet _bullet;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Shoot();
            }
        }

        public void Shoot()
        {
            Instantiate( _bullet, transform.position, Quaternion.identity);
        }
    }
}