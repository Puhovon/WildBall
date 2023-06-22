using System;
using UnityEngine;
using UnityEngine.UI;
public class Plate : MonoBehaviour
{
    [SerializeField] private Text pressButton;
    private Animation anim;
    [SerializeField] private AudioSource audio;
    private int count = 0;
    private bool playerOnTrigger = false;
    private void Awake()
    {
        anim = GameObject.Find("WallGateHarrowExit").GetComponentInChildren<Animation>();
    }

    private void FixedUpdate()
    {
        if (count < 1)
        {
            if (playerOnTrigger)
            {
                if (Input.GetKey(KeyCode.E))
                {
                    audio.Play();
                    anim.Play();
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pressButton.gameObject.SetActive(true);
            playerOnTrigger = true;
            pressButton.color = Color.white;
            pressButton.text = "Press [E] to open Exit Gate";
        }
    }

    private void OnTriggerExit(Collider other)
    {
        playerOnTrigger = false;
        pressButton.gameObject.SetActive(false);
    }
}
