using UnityEngine;
using Random = System.Random;

namespace Assets.Scripts
{
    public class RandomCube : MonoBehaviour
    {
        private Animator anim;
        private int random;

        private void Awake()
        {
            anim = GetComponent<Animator>();
        }

        private void FixedUpdate()
        {
            switch (random)
            {
                case 0:
                    anim.SetBool("Rotate", false);
                    break;
                case 1:
                    anim.SetBool("Rotate", true);
                    break;
            }
        }

        public void GetNewRandomInt()
        {
            Random rand = new Random();
            random = rand.Next(0, 2);
        }
    }
}