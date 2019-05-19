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
    public Record record;
    // Start is called before the first frame update
    void Start()
    {
        //initiate at start of game to prevent weired unity bug (i explain later)
        // you never explained later
        jumppower = 2500f;
        turnspeed = 100f;
        speed = 5f;

    }

    //controll Methods:
    string getMethodName()
    {
        return new System.Diagnostics.StackTrace(1).GetFrame(0).GetMethod().Name;
    }
    public void set_IsInAir(bool fickDichPatt)
    {
        isInAir = fickDichPatt ;
    }

    bool getInAir()
    {
        if (isInAir == true) return true;
        else return false;
    }
    string sprint()
    {
        transform.Translate(Vector3.forward * speed * sprintingMultiplicator * Time.deltaTime);
        return getMethodName();
    }
    string Key_W()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        return getMethodName();
    }
    string Key_S()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
        return getMethodName();
    }
    string Key_A()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        return getMethodName();
    }
    string Key_D()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        return getMethodName();
    }
    string jump()
    {
        rb.AddForce(0, jumppower, 0);
        return getMethodName();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            Key_W();
            if (Input.GetKey("left shift"))
            {
                log(sprint(), isOnRecord);

            }
        }
        if (Input.GetKey("s"))
        {
            log(Key_S(), isOnRecord);
        }
        if (Input.GetKey("a"))
        {
            log(Key_A(), isOnRecord);
        }
        if (Input.GetKey("d"))
        {
            log(Key_D(), isOnRecord);
        }
        if (Input.GetKey("space")) 
        {
            if(!getInAir())
            {
                log(jump(), isOnRecord);
                set_IsInAir(true);
                Debug.Log("i want to jump!");

            }

        }
    }


    public void log(string methodName, bool isOnRecord)
    {
        if (isOnRecord)
        {
            record.add(methodName);
        }
       
    }
    //this class was brought to you by your russian mate
}
