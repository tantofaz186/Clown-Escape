using UnityEngine;

public class Trapeze : MonoBehaviour
{

    [SerializeField] 
    private float maxAngle;
    [SerializeField] 
    private float period;
    
    private float z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        z += Time.deltaTime % (Mathf.PI * 2);
        
        var euler = new Vector3(0, 0, Mathf.Sin(z * period) * maxAngle);
        transform.rotation = Quaternion.Euler(euler);
        //ir do -maxAngle para o +maxAngle
        //rotação em Z

    }
    
}
