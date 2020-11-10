using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ChangeScenetwo : MonoBehaviour
{
    public float faderSpeed = 1.5f;
    //public float Speed2 = 2f;
    Image image;
    bool sceneStart = true;
    bool sceneEnd = false;

    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sceneStart)
        {
            StartScene();
        }

        if (Input.GetMouseButtonDown(0))
        {
            sceneEnd = true;
        }

        if (sceneEnd == true)
        {
            EndScene();
        }
    }
    void StartScene()
    {
        FaderToClear();
        if (image.color.a < 0.05f)
        {
            sceneStart = false;
        }
    }

    void FaderToClear()
    {
        image.color = Color.Lerp(image.color, Color.clear, faderSpeed * Time.deltaTime);
    }

    void EndScene()
    {
        FaderToBlack();
        if (image.color.a > 0.95f)
        {
            //重新加载新场景即可，激活场景
            SceneManager.LoadScene("2-10");
        }
    }

    void FaderToBlack()
    {
        image.color = Color.Lerp(image.color, Color.black, faderSpeed * Time.deltaTime);
    }
}
