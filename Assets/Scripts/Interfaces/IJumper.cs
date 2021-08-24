
using UnityEngine;

public interface IJumper
{
    void Jump();
    bool isGrounded { get; }
}
