using UnityEngine;

public class Enemy : GameOverOnCollision
{
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        transform.Translate(Vector3.right * (Time.deltaTime * speed));
    }
}
