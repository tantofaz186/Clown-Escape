using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float jumpForce;

    private Collider mainCharacterCollider;
    private void Start()
    {
        mainCharacterCollider = GameObject.Find("player").GetComponent<Collider>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider == mainCharacterCollider)
            collision.collider.attachedRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
