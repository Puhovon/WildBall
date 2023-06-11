using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySomething : MonoBehaviour
{
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("Collect");
    }


}
