using UnityEngine;
using Random = System.Random;


namespace Assets.Scripts.Player
{
    public class PlayerController : MonoBehaviour
    {
        private Animator anim;
        private Rigidbody rb;
        private int _num;
        Random rand = new Random();

        private void Awake()
        {
            anim = GetComponent<Animator>();
            rb = GetComponent<Rigidbody>();
            _num = 0;
        }

        private void FixedUpdate()
        {
            switch (_num)
            {
                case 0: 
                    anim.SetBool("GoPulling", false);
                    break;
                case 1:
                    anim.SetBool("GoPulling", true);
                    break;
            }
        }

        public int GetRandomNum => _num = rand.Next(0,2);
        //Debug.Log("Fixed Update");
        //if (Input.GetKey(KeyCode.W))
        //{
        //    rb.AddForce(0.5f, 0, 0);
        //    Debug.Log("Press W");

        //}

        //if (Input.GetKey(KeyCode.S))
        //{
        //    rb.AddForce(-0.5f, 0, 0);
        //    Debug.Log("Press S");

        //}

        //if (Input.GetKey(KeyCode.D))
        //{
        //    rb.AddForce(0, 0, 0.5f);
        //    Debug.Log("Press D");

        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    rb.AddForce(0, 0, -0.5f);
        //    Debug.Log("Press A");

        //}

        //anim.SetFloat("Velocity", rb.velocity.magnitude);
    }
}