using UnityEngine;

public class DestroyObstacleOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        var go = other.gameObject;
        if (go.layer == 6)//obstáculo
        {
            Destroy(go);
        }
    }
}
