using System;
using System.Collections;
using System.Diagnostics;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

namespace Finish
{
    public class Finish : MonoBehaviour
    {
        [SerializeField] private Text pressButton;
        private SceneController sceneController;
        
        private int thisSceneIndex;
        
        private void Awake()
        {
            sceneController = GameObject.Find("Manager").GetComponent<SceneController>();
        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log($"Name: {transform.name} Tag: {transform.tag} Parrent: {transform.parent.name} ");
            if (other.CompareTag("Player"))
            {
                Vector3 position = GameObject.FindGameObjectWithTag("Player").transform.position;
                Debug.Log($"position player: {position}, postion finish: {transform.position}");
                pressButton.gameObject.SetActive(true);
                pressButton.text = "press [E] to finish";
                pressButton.color = Color.white;
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (Input.GetKey(KeyCode.E))
            {
                sceneController.NextScene();
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
                pressButton.gameObject.SetActive(false);
        }

        
    }
}