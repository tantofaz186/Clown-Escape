using System;
using UnityEngine;

namespace PowerUps
{
    public class PowerUpEffect : MonoBehaviour
    {
        [SerializeField] private ParticleSystem particles;
        private void Awake()
        {
            if (particles == null)
            {
                particles = GetComponent<ParticleSystem>();
            }
        }

        void Start()
        {
            Destroy(gameObject, particles.main.duration);
        }

    }
}
