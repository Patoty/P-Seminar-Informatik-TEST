using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Record : MonoBehaviour
{

    private ArrayList methodCalls; //The index of the called methods will be saved here
    private Time intervalBetweenKeyPress;
    private string[] methodNames = {
        "sprint", "Key_W", "Key_S", "Key_A", "Key_D", "jump"
    };

    // Start is called before the first frame update
    void Start()
    {

    }

    public void add(string methodName)
    {
        //switch (methodName)
        //{
        //    case methodNames[0]:
        //        methodCalls.Add(2);
        //        break;
        //    case "sneak":
        //        break;

        //}
        for (int i = 0; i < methodNames.Length; i++)
        {
            if (methodName == methodNames[0])
            {
                methodCalls.Add(0);
                break;
            }

        }
    }

    public void replay()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
