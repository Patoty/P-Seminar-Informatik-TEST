using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feet : MonoBehaviour
{
    public Controls_new shuggarDaddy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      //#wankercode  
    }
    private void OnTriggerEnter(Collider other)
    {
        shuggarDaddy.set_IsInAir(false);
        
    }
        private void OnTriggerStay(Collider other)
    {
        shuggarDaddy.set_IsInAir(false);
        
    }
}
