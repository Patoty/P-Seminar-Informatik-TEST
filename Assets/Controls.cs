using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
   
    public Rigidbody rb;
    float turnspeed = 50f;
    void forward()
    {
        rb.AddForce(0, 0, 500 * Time.deltaTime);
    }
    void back()
    {
        rb.AddForce(0, 0, -500 * Time.deltaTime);
    }

    void left()
    {
        rb.AddForce(-500 * Time.deltaTime, 0 , 0);
    }
    void right()
    {
        rb.AddForce(500 * Time.deltaTime , 0 , 0);
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Finally");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            forward();
        }
        if (Input.GetKey("s"))
        {
            back();
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.up, -turnspeed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up, turnspeed * Time.deltaTime);
        }

    }
}
