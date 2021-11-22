using UnityEngine;

namespace PowerUps
{
    //invencibilidade e destruição de obstáculos
    public class PU_Car : Collectable
    {
        [SerializeField] private float effectTime;
        protected override void Collect()
        {
            player.AddInvincibility(effectTime);
            Destroy(gameObject);
        }
    }
}
