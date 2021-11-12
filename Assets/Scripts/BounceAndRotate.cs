using UnityEngine;

public class BounceAndRotate : MonoBehaviour
{

    [SerializeField] private float rotationSpeed;
    [SerializeField] private float pingPongDistance;
    [SerializeField] private float pingPongSpeed;

    private float elapsedDeltaTime = 0;
    private Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        elapsedDeltaTime += Time.deltaTime % (2 * Mathf.PI);
        transform.Rotate(Vector3.up,rotationSpeed * Time.deltaTime,Space.Self);
        transform.position = startPos + Vector3.up * (pingPongDistance * Mathf.Cos(elapsedDeltaTime * pingPongSpeed));
    }
}
