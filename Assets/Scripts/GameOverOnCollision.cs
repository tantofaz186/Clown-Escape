using System;
using UnityEngine;

public class GameOverOnCollision : MonoBehaviour
{
    protected static PlayerCharacter player;
    protected static Collider playerCollider;
    public static event Action CollidedWithCharacter;

    protected void Awake()
    {
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
        else if (other.TryGetComponent(out PlayerCharacter _))
        {
            CollidedWithCharacter?.Invoke();
        }

    }
}
