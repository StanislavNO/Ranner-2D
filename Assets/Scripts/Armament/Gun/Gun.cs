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
                Shoot();
        }

        public void Shoot()
        {
            AudioSource.Play();
            Instantiate( _bullet, transform.position + Vector3.right, Quaternion.identity);
        }
    }
}