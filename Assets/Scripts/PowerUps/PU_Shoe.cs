using UnityEngine;

namespace PowerUps
{
    //Velocidade
    public class PU_Shoe : Collectable
    {
        [SerializeField] private float speedChange;
        [SerializeField] private float effectTime;
        [SerializeField] private PowerUpEffect pickUpParticles;
        
        protected override void Collect()
        {
            Instantiate(pickUpParticles);
            player.ChangeMaxSpeed(speedChange, effectTime);
            Destroy(this);
        }
    }
}
