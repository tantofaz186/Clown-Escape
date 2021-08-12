using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float period;
    public Vector3 endPos;
    private Vector3 startPos;
    private float sin;

    private void OnValidate()
    {
        startPos = transform.position;
    }
    void Update()
    {
        sin += Time.deltaTime % (2 * Mathf.PI);//goes from 0 to 2*PI

        transform.position = startPos + endPos * ((Mathf.Sin(sin * period) + 1) / 2);
        
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.magenta;
        Gizmos.DrawWireSphere(endPos + startPos, 0.5f);
    }
}