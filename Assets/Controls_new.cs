using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls_new : MonoBehaviour
{
    //class is pretty self explanatory
    public Rigidbody rb;
    public float speed = 5f;
    public float turnspeed = 100f;
    public float jumppower = 2500f;
    public float sprintingMultiplicator = 2;
    public bool isInAir = false;
    public bool isOnRecord;
    // Start is called before the first frame update
    void Start()
    {
        //initiate at start of game to prevent weired unity bug (i explain later)
        jumppower = 2500f;
        turnspeed = 100f;
        speed = 5f;

    }
    //controll Methods:
    public void set_IsInAir(bool fickDichPatt)
    {
        isInAir = fickDichPatt ;
    }

    bool getInAir()
    {
        if (isInAir == true) return true;
        else return false;
    }
    void sprint()
    {
        transform.Translate(Vector3.forward * speed * sprintingMultiplicator * Time.deltaTime);
    }
    void Key_W()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    void Key_S()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
    void Key_A()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    void Key_D()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    void jump()
    {
        rb.AddForce(0, jumppower, 0);
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            Key_W();
            if (Input.GetKey("left shift"))
            {
                sprint();

            }
        }
        if (Input.GetKey("s"))
        {
            Key_S();
        }
        if (Input.GetKey("a"))
        {
            Key_A();
        }
        if (Input.GetKey("d"))
        {
            Key_D();
        }
        if (Input.GetKey("space")) 
        {
            if(!getInAir())
            {
                jump();
                set_IsInAir(true);
                Debug.Log("i want to jump!");

            }

        }
    }


    public void log(string methodName, bool isOnRecord)
    {
        if (isOnRecord)
        {
            Record.
        }
    }
    //this class was brought to you by your russian mate
}
