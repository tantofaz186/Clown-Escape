using System;
using UnityEngine;

public class Slider : MonoBehaviour
{
    private void Start()
    {
        
    }
    
    private void Update()
    {
        if (Input.GetButtonDown("Slide"))
        { 
            Slide();   
        }
    }

    private void Slide()
    {
        throw new NotImplementedException();
    }
}
