using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls_new : MonoBehaviour
{
    //class is pretty self explanatory
    public bool getcrouch = false;
    public Rigidbody rb;
    public float speed = 5f;
    public float turnspeed = 100f;
    public float jumppower = 400f;
    public float sprintingMultiplicator = 2;
    public bool isInAir = false;
    public bool enableSprint = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void set_enablesprint(bool x){
        enableSprint = x;
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
    //controll Methods:
    void sprint()
    {
        if(rb.useGravity == true){
        if(enableSprint == true){
        transform.Translate(Vector3.forward * speed * sprintingMultiplicator * Time.deltaTime);
    }
        }
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
          if (rb.useGravity == false)        
        {
             transform.Translate(Vector3.up * speed * Time.deltaTime);        
              
        } else
        {  
            rb.AddForce(0, jumppower, 0);
        }
        
        
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
        if (Input.GetKeyDown("c"))
        {
            if (rb.useGravity == true)
            {
            if(getcrouch == false)
            {
                transform.localScale += new Vector3(0, -1f, 0);
                getcrouch = true;
                set_enablesprint(false);
            } else 
            if(getcrouch == true)
            {
                transform.localScale += new Vector3(0, 1f, 0);
                getcrouch = false;
                set_enablesprint(true);
            }
            }
           
           
        }

        if (Input.GetKey("c"))
        { if (rb.useGravity == false)
        {
              transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

        }
        if (Input.GetKey("space")) 
        {
            if(!getInAir())
            {
                jump();
                set_IsInAir(true);
               
                
            }
        }
       
    }
    //this class was brought to you by your russian mate
    //all hail mischka
}
