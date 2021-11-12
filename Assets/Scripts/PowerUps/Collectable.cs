using UnityEngine;

namespace PowerUps
{
    public abstract class Collectable : MonoBehaviour
    {
        [SerializeField]protected PlayerCharacter player;

        private void Awake()
        {
            player = FindObjectOfType<PlayerCharacter>();
        }

        protected abstract void Collect();

        //power ups na layer power up só interagem com o Player, portanto não é preciso checar o collider
        protected virtual void OnTriggerEnter(Collider other)
        {
            Collect();
            Destroy(gameObject);
        }
    }
}
