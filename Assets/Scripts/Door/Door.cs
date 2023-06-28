using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    [SerializeField]private Text text;
    private bool canOpen = false;
    private Animation animation;
    private int counter = 0;
    private void Awake()
    {
        animation = GetComponentInChildren<Animation>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        { 
            text.gameObject.SetActive(true);
            text.text = "Press [E] to open door";
            text.color = Color.white;
            canOpen = true;
        }
    }

    private void FixedUpdate()
    {
        if (canOpen)
        {
            if (counter < 1)
            {
                if (Input.GetKey(KeyCode.E))
                {
                    animation.Play();
                    canOpen = false;
                }
            }
        }

        if (!canOpen)
        {
            text.gameObject.SetActive(false);
        }
    }
}
