using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogSysytem : MonoBehaviour
{
    [Header("UI组件")]
    public Text textLabel;
    public Image faceImage;
    

    [Header("文本文件")]
    public TextAsset textFile;
    public int index;
    public float textSpeed;

    bool textFinished;

    List<string> textList = new List<string>();

    // Start is called before the first frame update
    void Awake()
    {
        GetTextFromFile(textFile);
    }

    private void OnEnable()
    {
        //textLabel.text = textList[index];
        //index++;
        StartCoroutine(SetTextUI());
        textFinished = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && index == textList.Count)
        {
            gameObject.SetActive(false);
            index = 0;
            SceneManager.LoadScene("1-3");
            return;
        }
        if (Input.GetMouseButtonDown(0) && textFinished)
        {
            //textLabel.text = textList[index];
            //index++;

            StartCoroutine(SetTextUI());
        }
    }

    void GetTextFromFile(TextAsset file)
    {
        textList.Clear();
        index = 0;

        var lineDate = file.text.Split('\n');

        foreach(var line in lineDate)
        {
            textList.Add(line);
        }
    }

    IEnumerator SetTextUI()
    {
        textFinished = false;
        textLabel.text = "";
        for(int i = 0; i < textList[index].Length; i++)
        {
            textLabel.text += textList[index][i];
            yield return new WaitForSeconds(textSpeed);
        }
        textFinished = true; 
        index++;
    }
}
