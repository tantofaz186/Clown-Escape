using System;
using System.Collections;
using System.Collections.Generic;
using Interfaces;
using UnityEngine;

public class BreakOnCollision : MonoBehaviour,IBreakable
{
    private void OnCollisionEnter(Collision other)
    {
        Break();
    }

    [SerializeField]private AudioClip breakSound;
    private AudioSource audioSource;
    public void Break()
    {
        audioSource.PlayOneShot(breakSound);
        Destroy(gameObject);
    }
}
