using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager manager;

    public GameObject deathPanel;
    public GameObject winPanel;

    public void Awake()
    {
        manager = this;
    }

    public void GameOver()
    {
        deathPanel.SetActive(true);
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void WinLevel()
    {
        winPanel.SetActive(true);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
