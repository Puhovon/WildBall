using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.Finish
{
    public class FinishGame : MonoBehaviour
    {
        [SerializeField] private Text pressButton;
        private Game gameController;
        private Animation animation;
        private ParticleSystem particleSystem;

        private int thisSceneIndex;

        private void Awake()
        {
            animation = GetComponentInParent<Animation>();
            gameController = GameObject.Find("Manager").GetComponent<Game>();
            particleSystem = GameObject.FindGameObjectWithTag("ParticleSystem").GetComponent<ParticleSystem>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                pressButton.gameObject.SetActive(true);
                pressButton.text = "press [E] to finish";
                pressButton.color = Color.white;
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (Input.GetKey(KeyCode.E))
            {
                StartCoroutine(CompleteLevel());
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
                pressButton.gameObject.SetActive(false);
        }

        private IEnumerator CompleteLevel()
        {
            animation.Play();
            particleSystem.Play();
            yield return new WaitForSeconds(3);
            gameController.FinishGame();
        }
    }
}