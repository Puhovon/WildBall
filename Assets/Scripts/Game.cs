using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Assets.Scripts
{

    public class Game : MonoBehaviour
    {
        [SerializeField] private GameObject pause;
        [SerializeField] private GameObject mainOverlay;
        [SerializeField] private GameObject gameOver;
        [SerializeField] private GameObject FinishGameOverlay;
        
        [SerializeField] private Text pressButtonText;

        private void Awake()
        {
            mainOverlay.SetActive(true);
            pause.SetActive(false);
            gameOver.SetActive(false);
            FinishGameOverlay.SetActive(false);
            Time.timeScale = 1;
        }

        public void Pause()
        {
            Debug.Log("Pause");
            pause.SetActive(true);
            mainOverlay.SetActive(false);
            Time.timeScale = 0;
        }

        public void Resume()
        {
            mainOverlay.SetActive(true);
            pause.SetActive(false);
            Time.timeScale = 1;
        }

        public void GameOver()
        {
            Time.timeScale = 0;
            mainOverlay.SetActive(false);
            gameOver.SetActive(true);
        }

        public void FinishGame()
        {
            mainOverlay.SetActive(false);
            FinishGameOverlay.SetActive(true);
        }
    }
}