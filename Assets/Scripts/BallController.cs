using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
       {
        rb = GetComponent<Rigidbody>(); 

       }

    // Update is called once per frame
    void Update()
       {
        Vector3 tilt = Input.acceleration;
        rb.AddForce(tilt.x, 0, tilt.y);
       }
}
