using System;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public GameObject player;
    private Collider playerCollider;

    public static event Action CollidedWithCharacter;
    private void Start()
    {
        playerCollider = player.GetComponent<Collider>();

    }

    private void FixedUpdate()
    {
        transform.Translate((player.transform.position - transform.position).normalized 
                            * (Time.deltaTime * speed));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == playerCollider)
        {
            CollidedWithCharacter?.Invoke();
        }

    }
}
