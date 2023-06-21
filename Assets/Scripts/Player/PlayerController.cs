using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Player
{
    [RequireComponent(typeof(PlayerMovement))]
    public class PlayerController : MonoBehaviour
    {
        private Vector3 movement;
        private PlayerMovement playerMovement;
        private Game gameController;

        private void Awake()
        {
            playerMovement = GetComponent<PlayerMovement>();
            gameController = GameObject.Find("Manager").GetComponent<Game>();
        }

        private void Update()
        {
            float horizontal = Input.GetAxis(GlobalStringVar.HORIZONTAL_AXIS);
            float vertical = Input.GetAxis(GlobalStringVar.VERTICAL_AXIS);

            movement = new Vector3(horizontal, 0, vertical).normalized;
        }

        private void FixedUpdate()
        {
            playerMovement.MoveCharacter(movement);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("DeathTrigger"))
                gameController.GameOver();
        }
    }
}