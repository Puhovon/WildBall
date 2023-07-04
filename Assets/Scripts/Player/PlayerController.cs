using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts.Player
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerController : MonoBehaviour
    {
        private Vector3 movement;
        private PlayerMovement playerMovement;
        private Game gameController;
        private Animator animator;
        private ParticleSystem particleSystem;
        
        private void Awake()
        {
            particleSystem = GetComponentInChildren<ParticleSystem>();
            animator = GetComponent<Animator>();
            playerMovement = GetComponent<PlayerMovement>();
            gameController = GameObject.Find("Manager").GetComponent<Game>();
        }

        private void Update()
        {
            float horizontal = Input.GetAxis("Horizontal");
            float vertical = Input.GetAxis("Vertical");

            movement = new Vector3(horizontal,0 , vertical).normalized;
        }

        private void FixedUpdate()
        {
            playerMovement.MoveCharacter(movement);
        }
        
        
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("DeathTrigger"))
                StartCoroutine(Die());
        }

        private IEnumerator Die()
        {
            animator.SetTrigger("Die");
            yield return new WaitForSecondsRealtime(2);
            gameController.GameOver();
        }

        private void StartParticle()
        {
            particleSystem.Play();
        }
        
    }
}