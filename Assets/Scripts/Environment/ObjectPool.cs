using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Assets.Scripts
{
    public class ObjectPool : MonoBehaviour
    {
        [SerializeField] protected int Capacity;
        [SerializeField] private GameObject _container;

        private List<GameObject> _pool = new();

        protected void Initialize(GameObject _prefab)
        {
            GameObject spawned = Instantiate(
                _prefab,
                _container.transform);

            spawned.SetActive(false);
            _pool.Add(spawned);
        }

        protected bool TryGetObject(out GameObject result)
        {
            result = _pool.FirstOrDefault(p => p.activeSelf == false);

            return result != null;
        }
    }
}