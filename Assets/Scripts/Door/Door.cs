using UnityEngine;
using UnityEngine.UI;

namespace Door
{
    public class Door : MonoBehaviour
    {
        [SerializeField] private Text text;
        private bool canOpen = false;
        private Animation animation;
        private int counter = 0;

        private void Awake()
        {
            animation = GetComponentInChildren<Animation>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                text.gameObject.SetActive(true);
                text.text = "Press [E] to open door";
                text.color = Color.white;
                canOpen = true;
            }
        }

        private void Update()
        {
            if (canOpen)
            {
                if (counter < 1)
                {
                    if (Input.GetKey(KeyCode.E))
                    {
                        animation.Play();
                        canOpen = false;
                        counter++;
                    }
                }
            }

            if (counter >= 1)
            {
                text.gameObject.SetActive(false);
                Destroy(transform.GetComponent<Door>());   
            }
        }
    }
}