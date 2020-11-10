using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Line : MonoBehaviour
{
    public GameObject Pimage;
    public float SceneNumber;

    public float Rang_x;
    public float Rang_y;

    private float zx;
    private float zy;

    bool n = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseUp()
    {
        if (Mathf.Abs(transform.position.x - zx) <= Rang_x &&
                Mathf.Abs(transform.position.y - zy) <= Rang_y)
        {
            if(SceneNumber == 1)
            {
                SceneManager.LoadScene("1-1");
                Time.timeScale = 1f;
            }
            if (SceneNumber == 2)
            {
                SceneManager.LoadScene("1-2");
                Time.timeScale = 1f;
            }
            if (SceneNumber == 5)
            {
                SceneManager.LoadScene("1-5");
                Time.timeScale = 1f;
            }
            if (SceneNumber == 222)
            {
                SceneManager.LoadScene("Line2");
                Time.timeScale = 1f;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        zx = Pimage.transform.position.x;
        zy = Pimage.transform.position.y;
    }
}
