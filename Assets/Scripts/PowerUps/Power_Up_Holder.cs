using System;
using Interfaces;
using UnityEngine;

namespace PowerUps
{
    public class Power_Up_Holder : MonoBehaviour
    {

        [SerializeField] private Collectable powerUp;
        private void OnTriggerEnter(Collider other)
        {
            
            SpawnPowerUp();
            Destroy(gameObject);
        }

        private void SpawnPowerUp()
        {
            var transform1 = transform;
            Instantiate(powerUp,transform1.position,transform1.rotation);
        }
    }
}
