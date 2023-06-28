using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{

    public class Game : MonoBehaviour
    {
        [SerializeField] private GameObject pause,
            btn,
            gameOver;

        [SerializeField] private Text pressButtonText;

        private void Awake()
        {
            btn.SetActive(true);
            pause.SetActive(false);
            gameOver.SetActive(false);
            Time.timeScale = 1;
        }

        public void Pause()
        {
            Debug.Log("Pause");
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

        public void GameOver()
        {
            Time.timeScale = 0;
            btn.SetActive(false);
            gameOver.SetActive(true);
        }

        public void Print()
        {
            Debug.Log("Print");
        }
    }
}