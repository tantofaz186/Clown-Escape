using System;
using UnityEngine;

namespace PowerUps
{
    public class Collectable : MonoBehaviour
    {
        protected virtual void Collect()
        {
            Debug.Log($"{name} foi coletado");
            Destroy(gameObject);
        }

        protected virtual void OnTriggerEnter(Collider other)
        {
            Collect();
        }
    }
}
