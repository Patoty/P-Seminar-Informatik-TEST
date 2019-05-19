using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Record : MonoBehaviour
{

    private ArrayList methodCalls; //The index of the called methods will be saved here
    private Time intervalBetweenKeyPress;
    private string[] methodNames = {
        "sprint", "Key_W", "Key_S", "Key_A", "Key_D", "jump"
    };
    private Stopwatch temporaryInterval;
    private Vector3 initialPlayerPosition;

   
    
    // Start is called before the first frame update
    void Start()
    {
        temporaryInterval = new Stopwatch();
        temporaryInterval.Start();
    }

    public void setInitialPlayerPosition(Vector3 initialPlayerPosition)
    {
        this.initialPlayerPosition = initialPlayerPosition;
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
            if (methodName == methodNames[i])
            {
                /* What this is supposed to do:
                 * 1. get the time interval since the last method call 
                 * 2. save it to the methodCalls list
                 * 3. save the called method to the methodCalls list
                 * 4. restart the stopwatch
                 */
                temporaryInterval.Stop(); 
                System.TimeSpan ts = temporaryInterval.Elapsed;
                methodCalls.Add(ts.Duration());
                methodCalls.Add(i);
                temporaryInterval.Start();
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
