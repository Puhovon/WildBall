using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Assets.Scripts.Player
{
    [RequireComponent(typeof(Rigidbody))]
    
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 2.0f;
        private Rigidbody playerRigidbody;


        private void Awake()
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }
        public void MoveCharacter(Vector3 movement)
        {
            playerRigidbody.AddForce(movement * speed);
        }
#if UNITY_EDITOR

        [ContextMenu("Reset values")]
        public void ResetValue()
        {
            speed = 2;
        }
#endif
    }
}