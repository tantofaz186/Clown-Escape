using UnityEngine;

namespace PowerUps
{
    //Velocidade
    public class PU_Shoe : Collectable
    {
        [SerializeField] private float speedChange;
        [SerializeField] private float effectTime;
        [SerializeField] private ParticleSystem pickUpParticles;
        
        protected override void Collect()
        {
            Instantiate(pickUpParticles);
            Destroy(pickUpParticles, pickUpParticles.main.duration);
            player.ChangeMaxSpeed(speedChange, effectTime);
        }
    }
}
