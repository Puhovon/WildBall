using System.Collections;
using UnityEngine;

namespace Assets.Scripts
{
    public class CoroutineSample : MonoBehaviour
    {
        private void Start()
        {
            StartCoroutine(timer());
        }

        private IEnumerator timer()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return new WaitForSeconds(2);
            }
        }
    }
}