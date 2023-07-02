using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class SceneController : MonoBehaviour
    {
        public void ChangeScene(int Index)
        {
            SceneManager.LoadScene(Index);
        }

        public void NextScene()
        {
            int indexOfThisScene = SceneManager.GetActiveScene().buildIndex;
            if (indexOfThisScene + 1 < 4)
            {
                SceneManager.LoadScene(indexOfThisScene + 1);
            }
            else
            {
                SceneManager.LoadScene(0);
            }
        }
        
        public void ReloadScene()
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index);
        }
    }
}