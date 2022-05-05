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
    void update()
    {

        //if(Input.GetKeyDown(KeyCode.Space))
        if (timer <= 200.00f && canCount)
        {
            
            foreach (GameObject g in platforms)
            {
                
                g.GetComponent<Rigidbody>().isKinematic = false;
            }
        }
        
    }

}
