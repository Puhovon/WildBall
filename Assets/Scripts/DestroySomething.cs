using UnityEngine;

namespace Assets.Scripts
{
    public class DestroySomething : MonoBehaviour
    {
        private Animator anim;

        void Awake()
        {
            anim = GetComponent<Animator>();
        }

        void OnTriggerEnter(Collider other)
        {
            anim.SetTrigger("Collect");
        }
    }
}