using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look : MonoBehaviour
{
   
    public float sensitivity = 5f;
    //shuggar daddy
    private Transform myBody;
    private Vector2 mouseDirection;

    // Start is called before the first frame update duhh
    void Start()
    {
        myBody = this.transform.parent.transform;
    }
    void update_camera()
    {
        //How much has the mouse moved?
        Vector2 mouseChange = new Vector2
            (Input.GetAxisRaw("Mouse X"),
             Input.GetAxisRaw("Mouse Y"));
        mouseDirection += mouseChange;

	//apply mouse movement to player object
        this.transform.localRotation = Quaternion.AngleAxis(-mouseDirection.y * sensitivity, Vector3.right);

        myBody.localRotation = Quaternion.AngleAxis(mouseDirection.x * sensitivity, Vector3.up);
        

	//I`m too lazy to comment here... it`s a foocking cunt of a wanker mess mate
    }
    // Update is called once per frame duh
    void Update()
    {
        update_camera();
    }
    //this class was brought to you by your russian mate

	void log(Vector2 sC){
		Vector2 saveChanged = sC;
		
	}	
}

//this class is a shit

