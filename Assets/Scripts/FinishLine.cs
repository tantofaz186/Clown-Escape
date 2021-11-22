using System;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public event Action OnFinish;
    private void OnTriggerEnter(Collider other)
    {
        OnFinish?.Invoke();
    }
}
