using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour, ISlider
{
    
    private SwipeDetection inputDetection;
    private void Awake()
    {
        inputDetection = SwipeDetection.Instance;
    }

    private void OnEnable()
    {
        inputDetection.OnSwipeUp += Jump;

    }

    private void OnDisable()
    {
        inputDetection.OnSwipeUp -= Jump;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Slide()
    {
        throw new System.NotImplementedException();
    }
}
