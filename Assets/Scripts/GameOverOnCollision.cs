using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverOnCollision : MonoBehaviour
{
    protected static PlayerCharacter player;
    protected Collider playerCollider;
    public static event Action CollidedWithCharacter;

    private void Awake()
    {
        if(player == null)
            player = FindObjectOfType<PlayerCharacter>();
        playerCollider = player.GetComponent<Collider>();
    }
    protected void OnTriggerEnter(Collider other)
    {
        if (other == playerCollider)
        {
            CollidedWithCharacter?.Invoke();
        }

    }
}
