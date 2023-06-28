using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    [SerializeField] private Text pressButton;
    private SceneController sceneController;
    private bool playerOnTrigger = false;
    private int thisSceneIndex;
    private void Awake()
    {
        sceneController = GameObject.Find("Manager").GetComponent<SceneController>();
        
    }

    private void FixedUpdate()
    {
        if (playerOnTrigger)
        {
            if (Input.GetKey(KeyCode.E))
            {
                sceneController.ChangeScene(0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pressButton.gameObject.SetActive(true);
            pressButton.text = "press [E] to finish";
            pressButton.color = Color.white;
            playerOnTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        playerOnTrigger = false;
    }
}
