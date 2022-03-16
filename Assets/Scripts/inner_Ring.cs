using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class inner_Ring : MonoBehaviour
{
    private const bool V = false;
    public GameObject RING;

    private void Update()
    {
        int numPlatforms = 6;
        if (Input.GetKeyDown(KeyCode.S))
        {
            for(int i =0; i < numPlatforms; i++)
            {
                object p = gameObject.GetComponents<MeshRenderer>(V);
            }
        }
        
    }

}
