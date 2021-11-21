using System;
using UnityEngine;

public class Enemy : GameOverOnCollision
{
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        transform.Translate((player.transform.position - transform.position).normalized 
                            * (Time.deltaTime * speed));
    }
}
