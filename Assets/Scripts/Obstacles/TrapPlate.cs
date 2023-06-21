using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapPlate : MonoBehaviour
{
    private Animator animator;
    private float time = 0;
    
    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
        if (other.CompareTag("Player"))
        {
            StartCoroutine(WaitTwoSecondsForUpStakes());
            time += Time.deltaTime;

            if (time >= 10)
            {
                animator.SetFloat("Time", time);
            }

            time = 0;
        }
    }

    private IEnumerator WaitTwoSecondsForDownStakes()
    {
        for (int i = 0; i < 2; i += 1)
        {
            yield return new WaitForSecondsRealtime(1);
            time += 1;
        }
        
    }

    private IEnumerator WaitTwoSecondsForUpStakes()
    {
        for (int i = 0; i < 2; i += 1)
        {
            yield return new WaitForSecondsRealtime(1);
        }
        animator.SetTrigger("PlayerStay");

    }
}
