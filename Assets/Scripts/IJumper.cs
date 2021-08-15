
using UnityEngine;

public interface IJumper
{
    bool IsGrounded(Collider col);
    float DisTanceToGround(Collider col);
    void Jump();
}