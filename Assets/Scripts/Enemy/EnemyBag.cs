using UnityEngine;

namespace Assets.Scripts
{
    public class EnemyBag : MonoBehaviour
    {
        [SerializeField] private Medicament _loot;

        public void GetLoot()
        {
            Instantiate(_loot, transform.position, Quaternion.identity);
        }
    }
}