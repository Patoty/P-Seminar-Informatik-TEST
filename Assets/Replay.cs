using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Replay : MonoBehaviour
{


    public static ArrayList calledMethods = Record.methodCalls;
    public static Controls_new controls = controls.GetComponent<Controls_new>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void replay()
    {
        controls.replay(calledMethods);
    }
}
