using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuSelection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void StageSelect()
    {
        SceneManager.LoadScene("Level Selection");
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
