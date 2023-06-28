using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateMoving : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
            collision.transform.SetParent(transform);
        
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
            collision.transform.SetParent(null);
    }
}