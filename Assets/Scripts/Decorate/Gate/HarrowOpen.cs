using UnityEngine.UI;
using UnityEngine;

namespace Decorate.Gate
{
    public class HarrowOpen : MonoBehaviour
    {
        [SerializeField] private AudioSource audio;
        [SerializeField] private Text textToPress;
        private Animation anim;
        private bool playerOnTrigger = false;
        private int countOfOpen = 0;

        private void Awake()
        {
            anim = GetComponentInParent<Animation>();
            Debug.Log(audio.clip.name);
        }

        private void Update()
        {
            if (countOfOpen < 1)
            {
                if (playerOnTrigger)
                {
                    if (Input.GetKey(KeyCode.E))
                    {
                        anim.Play();
                        audio.Play();
                        countOfOpen++;
                    }
                }
            }

            if (countOfOpen >= 1)
            {
                Destroy(transform.GetComponent<HarrowOpen>());
                textToPress.gameObject.SetActive(false);
            }
        }

        private void OnTriggerStay(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                textToPress.gameObject.SetActive(true);
                textToPress.color = Color.white;
                textToPress.text = "Press [E] to open Gate";
            }

            playerOnTrigger = true;
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                playerOnTrigger = false;
            }
        }
    }
}