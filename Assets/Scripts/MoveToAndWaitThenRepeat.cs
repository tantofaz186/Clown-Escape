using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToAndWaitThenRepeat : MonoBehaviour
{
    [SerializeField] private Vector3 endPos;
    private Vector3 startPos;
    [SerializeField] private float waitTime;
    private float timeWaiting = 0;
    RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        startPos = rectTransform.localPosition;
        endPos = endPos + rectTransform.localPosition;
    }

    private void Update()
    {

        if (Vector3.Distance(rectTransform.localPosition, endPos) > 10f)
            rectTransform.localPosition += (endPos - startPos) * Time.deltaTime;
        if (timeWaiting >= waitTime)
        {
            rectTransform.localPosition = startPos;
            timeWaiting = 0;
        }
        timeWaiting += Time.deltaTime;
        
    }

}
