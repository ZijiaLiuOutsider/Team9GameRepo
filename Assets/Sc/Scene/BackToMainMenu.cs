using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void loadGame()
    {
        SceneManager.LoadScene("1-1");
    }

    public void LoadLine()
    {
        SceneManager.LoadScene("Line");
    }

    public void QuiteGame()
    {
        Application.Quit();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
