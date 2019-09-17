using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb_wall_X : MonoBehaviour
{
    public CapsuleCollider Player;
    public Rigidbody rb;
    // VERY IMPORTANT: (level design)
    //Horizontal use: y=2, has to touch ceiling
    //Vertical use: x or y =2, has to touch ground,has to touch wall, wall, no collision or you get thrown away
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other==Player)
        {
        rb.useGravity = false;

        rb.velocity = new Vector3(0, 0, 0);
        }
        
    }
    private void OnTrigerStay(Collider other)
    {
           if(other==Player)
        {
        rb.useGravity = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
           if(other==Player)
        {
        rb.useGravity = true;
        }
    }
}

