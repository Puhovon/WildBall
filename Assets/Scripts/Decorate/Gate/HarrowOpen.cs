using System;
using System.Collections;
using Assets.Scripts;
using UnityEngine;

public class HarrowOpen : MonoBehaviour
{
    [SerializeField] private AudioSource audio;
    private Animation anim;
    private Game gameController;
    private bool playerOnTrigger = false;
    private int countOfOpen = 0;
    private void Awake()
    {
        anim = GetComponentInParent<Animation>();
        Debug.Log(audio.clip.name);
        gameController = GameObject.Find("Manager").GetComponent<Game>();
    }

    private void FixedUpdate()
    {
        if(countOfOpen < 1)
        {
            if (playerOnTrigger)
            {
                if (Input.GetKey(KeyCode.E))
                {
                    anim.Play();
                    audio.Play();
                    countOfOpen++;
                }
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(gameController.pressText());
        }

        playerOnTrigger = true;
    }

    private void OnTriggerExit(Collider other)
    {
        playerOnTrigger = false;
    }
}
