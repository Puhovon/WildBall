using System.Collections;
using UnityEngine;

namespace Plate
{
    public class TopDownPlate : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private int speed;
        [SerializeField] private Transform point;
        public bool canMove = false;

        private int i;
        private bool reverse;
        private Rigidbody rigidbody;
        private Vector3 movement;
        
        private void Awake()
        {
            movement = new Vector3(0, 1, 0);
            rigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            CheckСanMove();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
                canMove = true;
        }

        private void OnCollisionExit(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
                canMove = false;
        }

        private void Move()
        {
            rigidbody.MovePosition(transform.position + movement * Time.deltaTime * speed);
        }

        private void CheckСanMove()
        {   
            if(Vector3.Distance(transform.position, point.position) < 0.01f)
            {
                canMove = false;
                Destroy(GetComponent<TopDownPlate>());
            }

            if (canMove)
            {
                Move();
            }
        }
    }
}