using System;
using UnityEngine;

public class GameOverOnCollision : MonoBehaviour
{
    protected static PlayerCharacter player;
    protected static Collider playerCollider;
    public static event Action CollidedWithCharacter;

    public static bool playerIsInvincible = false;

    private void DestroyComponentIfPlayerInvincible()
    {
        if (playerIsInvincible)
            Destroy(this);
    }

    protected void Awake()
    {
        DestroyComponentIfPlayerInvincible();
        if (player == null)
        {
            player = FindObjectOfType<PlayerCharacter>();
            playerCollider = player.GetComponent<Collider>();
        }
    }
    protected void OnTriggerEnter(Collider other)
    {
        if (other == playerCollider)
        {
            CollidedWithCharacter?.Invoke();
        }
        //else if (other.TryGetComponent(out PlayerCharacter _))
        //{
        //    CollidedWithCharacter?.Invoke();
        //}

    }
    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == playerCollider)
        {
            CollidedWithCharacter?.Invoke();
        }
        //else if (other.TryGetComponent(out PlayerCharacter _))
        //{
        //    CollidedWithCharacter?.Invoke();
        //}

    }
}
