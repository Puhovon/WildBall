using UnityEngine;

namespace Assets.Scripts
{
    public class MainMenuManager : MonoBehaviour
    {
        [SerializeField] private GameObject chooseLevel;
        [SerializeField] private GameObject settings;
        [SerializeField] private GameObject mainMenu;

        private void Awake()
        {
            mainMenu.SetActive(true);
            chooseLevel.SetActive(false);
            settings.SetActive(false);
        }
        

        public void OpenSettings()
        {
            mainMenu.SetActive(false);
            settings.SetActive(true);
        }

        public void OpenLevels()
        {
            mainMenu.SetActive(false);
            chooseLevel.SetActive(true);
        }

        public void ReturnToMainMenu()
        {
            mainMenu.SetActive(true);
            chooseLevel.SetActive(false);
            settings.SetActive(false);
        }

        public void Exit()
        {
            Application.Quit();
        }
    }
}