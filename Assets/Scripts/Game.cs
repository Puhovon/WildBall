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
        [SerializeField] private GameObject finishGameOverlay;
        
        [SerializeField] private Text pressButtonText;

        private void Awake()
        {
            finishGameOverlay.SetActive(false);
            mainOverlay.SetActive(true);
            pause.SetActive(false);
            gameOver.SetActive(false);
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
            finishGameOverlay.SetActive(true);
        }
    }
}