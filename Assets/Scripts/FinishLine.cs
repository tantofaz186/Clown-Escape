using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public event Action OnFinish;
    private void OnTriggerEnter(Collider other)
    {
        OnFinish?.Invoke();
    }
}
