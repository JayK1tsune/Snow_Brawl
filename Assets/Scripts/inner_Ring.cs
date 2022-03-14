using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class inner_Ring : MonoBehaviour
{
    public GameObject RING;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        RING.GetComponent<Animator>().Play("Ring down");
        
    }

}
