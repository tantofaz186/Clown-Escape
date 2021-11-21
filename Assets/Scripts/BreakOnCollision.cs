using System;
using System.Collections;
using System.Collections.Generic;
using Controllers;
using Interfaces;
using UnityEngine;

public class BreakOnCollision : MonoBehaviour,IBreakable
{    
    [SerializeField]private AudioClip breakSound;
    private AudioSource audioSource;
    private void Awake()
    {
        audioSource = AudioManager.Instance.audioSource;
    }
    

    private void OnCollisionEnter(Collision other)
    {
        other.gameObject.GetComponent<PlayerCharacter>().HitWall();
        Break();
    }


    public void Break()
    {
        if(!audioSource.isPlaying)
            audioSource.PlayOneShot(breakSound);
        Destroy(gameObject);
    }
}
