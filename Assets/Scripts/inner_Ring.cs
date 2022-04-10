using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class inner_Ring : Countdown
{
    GameObject[] platforms;
  

    void Start()
    {
        platforms = GameObject.FindGameObjectsWithTag("Frist_Ring_Sections");

 
    }
    void Update()
    {

        //if(Input.GetKeyDown(KeyCode.Space))
        if (timer <= 200.0f)
        {
            
            foreach (GameObject g in platforms)
            {
                
                g.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
        
    }

}
