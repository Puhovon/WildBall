using UnityEngine;

namespace Assets.Scripts
{
    public class SpringCube : MonoBehaviour
    {
        private Animator _anim;
        private int _count;
        
        public int CounterBeforeSpring => _count++;
        public int CounterAfterSpring => _count = 0;

        private void Start()
        {
            _anim = GetComponent<Animator>();
            _count = 0;
        }

        private void Update()
        {
            if (_count >= 2)
            {
                _anim.SetBool("GoSpring", true);
            }
            else
            {
                _anim.SetBool("GoSpring", false);
            }
        }
    }
}