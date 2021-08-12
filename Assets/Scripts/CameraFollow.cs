using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject objectToFollow;

    [Range(0f, 1f)]
    public float interpolation;

    private Vector3 vectorDistance;
    
    private void Start()
    {
        vectorDistance = transform.position - objectToFollow.transform.position;
    }
    
    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, 
            objectToFollow.transform.position + vectorDistance, interpolation);
    }
}
