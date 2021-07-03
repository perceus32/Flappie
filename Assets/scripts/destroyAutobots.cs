

using UnityEngine;

public class destroyAutobots : MonoBehaviour
{
    private float xUpper;
    private float xLower = -15f;
    public GameObject child; 

    void Start()
    {
        
    }
    void Update() {
        child = this.transform.GetChild(0).gameObject;
        if (child.transform.position.x < xLower)
        {
            Destroy(child);
        }
            }
}
