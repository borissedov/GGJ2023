using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void StartGame()
    {
        // Debug.Log("StartGameClicked");
        SceneManager.LoadScene("1stScene");
    }
    
    public void About()
    {
        // Debug.Log("AboutClicked");
        SceneManager.LoadScene("AboutScreen");
    }
    
    public void Exit()
    {
        Application.Quit();
    }
}
