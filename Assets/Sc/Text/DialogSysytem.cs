using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class DialogSysytem : MonoBehaviour
{
    [Header("文本完成后跳转场景序号")]
    public float sequz;

    [Header("UI组件")]
    public Text textLabel;
    public Image faceImage;
    
    [Header("文本文件")]
    public TextAsset textFile;
    public int index;
    public float textSpeed;

    [Header("对话头像")]
    public Sprite face01;
    public Sprite face02;
    public Sprite face03;
    public Sprite face04;
    public Sprite face05;
    public Sprite face06;
    public Sprite face07;
    public Sprite face08;
    public Sprite face09;
    public Sprite face10;
    public Sprite face11;
    public Sprite face12;

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
            //太高端的写不来 写个简单的凑活一哈
            if(sequz == 3)
            {
              SceneManager.LoadScene("1-3");
            }else if(sequz == 6){
              SceneManager.LoadScene("1-6");
            }
            
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

        //if (textList[index] == "A")  
        //{
        //    faceImage.sprite = face01;
        //    index++;
        //    Debug.Log("头像加载成功code1");
        //}
        
        switch (textList[index])
        {
            case "A":
                faceImage.sprite = face01;
                index++;
                Debug.Log("switchLoadingSuccess code1");
                break;
            case "B":
                faceImage.sprite = face02;
                index++;
                Debug.Log("switchLoadingSuccess code2");
                break;
                
            case "C":
                faceImage.sprite = face03;
                index++;
                Debug.Log("switchLoadingSuccess code3");
                break;
               
            case "D":
                faceImage.sprite = face04;
                index++;
                Debug.Log("switchLoadingSuccess code4");
                break;
                
            case "E":
                faceImage.sprite = face05;
                index++;
                Debug.Log("switchLoadingSuccess code5");
                break;
                
            case "F":
                faceImage.sprite = face06;
                index++;
                Debug.Log("switchLoadingSuccess code6");
                break;
                ;
            case "G":
                faceImage.sprite = face07;
                index++;
                Debug.Log("switchLoadingSuccess code7");
                break;

            case "H":
                faceImage.sprite = face08;
                index++;
                Debug.Log("switchLoadingSuccess code8");
                break;
            case "I":
                faceImage.sprite = face09;
                index++;
                Debug.Log("switchLoadingSuccess code9");
                break;
            case "J":
                faceImage.sprite = face10;
                index++;
                Debug.Log("switchLoadingSuccess code10");
                break;
            case "K":
                faceImage.sprite = face11;
                index++;
                Debug.Log("switchLoadingSuccess code11");
                break;
            case "L":
                faceImage.sprite = face12;
                index++;
                Debug.Log("switchLoadingSuccess code12");
                break;
        }

        for (int i = 0; i < textList[index].Length; i++)
        {
            textLabel.text += textList[index][i];
            yield return new WaitForSeconds(textSpeed);
        }
        textFinished = true; 
        index++;
    }
}
