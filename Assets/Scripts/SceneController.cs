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

        public void ReloadScene()
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index);
        }
    }
}