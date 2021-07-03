using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float pipesVelocity=3.2f;
    public void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = pipesVelocity * Vector2.left;    //Vector2.left : (-1,0)

        
    }
   // void Awake()
    /*{
        gameObject.GetComponent<Rigidbody2D>().velocity = pipesVelocity * Vector2.left;
    }*/
}//program start - void start
 //object intiliased - void awake
