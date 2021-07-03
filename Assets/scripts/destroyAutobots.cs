

using UnityEngine;

public class destroyAutobots : MonoBehaviour
{
    private float xUpper;
    private float xLower = -15f;

    void Start()
    {
        
    }
    void Update() {
        if (gameObject.transform.position.x < xLower)
        {
            Destroy(gameObject);
        }
            }
}
