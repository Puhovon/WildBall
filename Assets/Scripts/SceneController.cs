using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public void ChangeScene(int Index)
    {
        SceneManager.LoadScene(Index);
    }
}
