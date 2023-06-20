using UnityEngine;

namespace Assets.Scripts
{

    public class Game : MonoBehaviour
    {
        [SerializeField] private GameObject pause, btn;

        private void Awake()
        {
            btn.SetActive(true);
            pause.SetActive(false);
            Time.timeScale = 1;
        }

        public void Pause()
        {
            pause.SetActive(true);
            btn.SetActive(false);
            Time.timeScale = 0;
        }

        public void Resume()
        {
            btn.SetActive(true);
            pause.SetActive(false);
            Time.timeScale = 1;
        }
    }
}