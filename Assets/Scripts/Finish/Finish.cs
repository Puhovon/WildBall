using System;
using System.Collections;
using Assets.Scripts;
using UnityEngine;
using UnityEngine.UI;

namespace Finish
{
    public class Finish : MonoBehaviour
    {
        [SerializeField] private Text pressButton;
        private SceneController sceneController;
        private Animation animation;
        private ParticleSystem particleSystem;
        
        private bool playerOnTrigger = false;
        private int thisSceneIndex;
        

        private void Awake()
        {
            animation = GetComponentInParent<Animation>();
            sceneController = GameObject.Find("Manager").GetComponent<SceneController>();
            particleSystem = GameObject.FindGameObjectWithTag("ParticleSystem").GetComponent<ParticleSystem>();
        }

        private void Update()
        {
            if (playerOnTrigger)
            {
                
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

        private void OnTriggerStay(Collider other)
        {
            if (Input.GetKey(KeyCode.E))
            {
                StartCoroutine(CompleteLevel());
            }
        }

        private void OnTriggerExit(Collider other)
        {
            playerOnTrigger = false;
        }

        private IEnumerator CompleteLevel()
        {
            animation.Play();
            particleSystem.Play();
            yield return new WaitForSeconds(3);
        }
    }
}