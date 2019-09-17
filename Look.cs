using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
    public float sensitivity = 5f;
    //shuggar daddy
    private Transform myBody;
    
    //mouse direction = mD
    private Vector2 mD;
    

    // Start is called before the first frame update duhh
    void Start()
    {
        myBody = this.transform.parent.transform;
    }
    void update_camera()
    {
        //mouse change = mC
        //How much has the mouse moved?
        Vector2 mC = new Vector2
            (Input.GetAxisRaw("Mouse X"),
             Input.GetAxisRaw("Mouse Y"));
        mD += mC;
        this.transform.localRotation = Quaternion.AngleAxis(-mD.y * sensitivity, Vector3.right);
       
           myBody.localRotation = Quaternion.AngleAxis(mD.x * sensitivity, Vector3.up);
       
        


        //I`m too lazy to comment here... it`s a foocking cunt of a wanker mess mate
    }
    // Update is called once per frame duh
    void Update()
    {
        update_camera();
    }

    //this class was brought to you by your russian mate
    
}
