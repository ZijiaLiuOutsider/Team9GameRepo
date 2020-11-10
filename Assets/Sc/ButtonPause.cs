using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonPause : MonoBehaviour
{
    public GameObject ingameMenu;
    public GameObject Lboard;

    public void OnPause()
    {
        Time.timeScale = 0;
        ingameMenu.SetActive(true);
    }

    public void OnBoard()
    {
        Lboard.SetActive(true);
    }
    public void CloseBoard()
    {
        Lboard.SetActive(false);
    }

    public void OnResume()
    {
        Time.timeScale = 1f;
        ingameMenu.SetActive(false);
    }

    public void OnRestart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void BackToMAinMenu()
    {
        SceneManager.LoadScene("Mainmenu");
    }

    public void ReLoadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
    public void LoadLine()
    {
        SceneManager.LoadScene("Line");
    }
}