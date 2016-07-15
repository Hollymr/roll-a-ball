using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Rigidbody rb;
    public float speed;// allows you to change speed from the inspector in unity 

    void Start()
    {   // grabs rigidbody component from unity 
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate ()
    {
        float movehorizontal = Input.GetAxis("Horizontal");
        float movevertical = Input.GetAxis("Vertical");

        Vector3 force = new Vector3(movehorizontal, 0, movevertical);
        // add force needs a vector3 which we grabbed from ^^
        rb.AddForce(force * speed );// multiplying force * speed to quicken speed of roll 
       
    }
}
