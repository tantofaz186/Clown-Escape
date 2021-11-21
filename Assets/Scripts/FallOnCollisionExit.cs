using UnityEngine;

public class FallOnCollisionExit : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionExit(Collision other)
    {
        Fall();
    }

    private void Fall()
    {
        rb.useGravity = true;
        rb.isKinematic = false;
    }
}