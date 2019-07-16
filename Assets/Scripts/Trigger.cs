using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter(Collider Trigger)
    {
        if (Trigger.gameObject.tag == "Player") 
        {
           
            GameObject Player = Trigger.gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
