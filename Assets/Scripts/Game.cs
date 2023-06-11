using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private GameObject pause;
    public void Pause()
    {
        pause.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
    }
}
