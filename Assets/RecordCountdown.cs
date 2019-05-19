using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordCountdown : MonoBehaviour
{
    public static float countdownTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public static void startCountdown()
    {
        countdownTimer = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        countdownTimer -= Time.deltaTime;
        if (countdownTimer < 0 && Controls_new.globalIsOnRecord)
        {
            Controls_new.globalIsOnRecord = false;
        }
    }
}
