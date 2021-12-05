using UnityEngine;

public class Enemy : GameOverOnCollision
{
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.back * (Time.deltaTime * speed));
    }
}
