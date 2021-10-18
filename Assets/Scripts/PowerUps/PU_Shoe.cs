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
            var transform1 = transform;
            var go = Instantiate(pickUpParticles, transform1.position, Quaternion.identity);
            go.transform.Rotate(new Vector3(0,90,0), Space.Self);
            player.ChangeMaxSpeed(speedChange, effectTime);
            Destroy(this);
        }
    }
}
