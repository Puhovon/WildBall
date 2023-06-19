using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerController : MonoBehaviour
    {
        private Animator anim;
        private Rigidbody rb;
        private float velocityZ;


        private void Awake()
        {
            anim = GetComponent<Animator>();
            rb = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            Debug.Log("Fixed Update");
            if (Input.GetKey(KeyCode.W))
            {
                rb.AddForce(0.5f, 0, 0);
                Debug.Log("Press W");

            }

            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(-0.5f, 0, 0);
                Debug.Log("Press S");

            }

            if (Input.GetKey(KeyCode.D))
            {
                rb.AddForce(0, 0, 0.5f);
                Debug.Log("Press D");

            }

            if (Input.GetKey(KeyCode.A))
            {
                rb.AddForce(0, 0, -0.5f);
                Debug.Log("Press A");

            }

            anim.SetFloat("Velocity", rb.velocity.magnitude);

        }

        private void Walk()
        {
            anim.SetTrigger("");
        }

        private void GoRight()
        {

        }

        private void GoLeft()
        {

        }
    }
}