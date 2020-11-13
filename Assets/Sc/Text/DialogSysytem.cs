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
    public Sprite face13;
    public Sprite face14;

    [Header("场景中是否有对话语音")]
    public bool audioON = false;

    [Header("对话音频(bool对应是否加载对应位置的音频)")]
    public bool BOOL_AC0 = false;
    public AudioClip AC0;
    public bool BOOL_AC1 = false;
    public AudioClip AC1;
    public bool BOOL_AC2 = false;
    public AudioClip AC2;
    public bool BOOL_AC3 = false;
    public AudioClip AC3;
    public bool BOOL_AC4 = false;
    public AudioClip AC4;
    public bool BOOL_AC5 = false;
    public AudioClip AC5;
    public bool BOOL_AC6 = false;
    public AudioClip AC6;
    public bool BOOL_AC7 = false;
    public AudioClip AC7;
    public bool BOOL_AC8 = false;
    public AudioClip AC8;
    public bool BOOL_AC9 = false;
    public AudioClip AC9;
    public bool BOOL_AC10 = false;
    public AudioClip AC10;

    
    
    [Header("场景中音频播放序号")]
    public int countnum = 0;//记录播放的语音的序号

    bool textFinished;
    bool cancelTyping;
  
    

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
            if (sequz == 3)
            {
                SceneManager.LoadScene("1-3");
            }
            else if (sequz == 6)
            {
                SceneManager.LoadScene("1-6");
            }
            else if (sequz == 8)
            {
                SceneManager.LoadScene("1-8");
            }
            else if (sequz == 9)
            {
                SceneManager.LoadScene("1-9");
            }
            else if (sequz == 11)
            {
                SceneManager.LoadScene("1-11");
            }
            else if (sequz == 12)
            {
                SceneManager.LoadScene("1-12");
            }
            else if (sequz == 13)
            {
                SceneManager.LoadScene("1-13");
            }
            else if (sequz == 14)
            {
                SceneManager.LoadScene("1-14");
            }
            else if (sequz == 15)
            {
                SceneManager.LoadScene("1-15");
            }
            else if (sequz == 16)
            {
                SceneManager.LoadScene("1-16");
            }
            else if (sequz == 22)
            {
                SceneManager.LoadScene("2-2");
            }
            else if (sequz == 27)
            {
                SceneManager.LoadScene("2-7");
            }
            else if (sequz == 24)
            {
                SceneManager.LoadScene("2-4");
            }
            else if (sequz == 28)
            {
                SceneManager.LoadScene("2-8");
            }
            else if (sequz == 213)
            {
                SceneManager.LoadScene("2-13");
            }
            else if (sequz == 215)
            {
                SceneManager.LoadScene("2-15");
            }
            return;
        }
        //if (Input.GetMouseButtonDown(0) && textFinished)
        //{
        //    //textLabel.text = textList[index];
        //    //index++;

        //    StartCoroutine(SetTextUI());
        //}
        if (Input.GetMouseButtonDown(0))
        {
            if (textFinished && !cancelTyping)
            {
                StartCoroutine(SetTextUI());
            }
            else if(textFinished == false && !cancelTyping){
                cancelTyping = true;
            }
        }
    }

    void GetTextFromFile(TextAsset file)
    {
        textList.Clear();
        index = 0;

        var lineData = file.text.Split('\n');

        foreach(var line in lineData)
        {
            textList.Add(line);
        }
    }

    IEnumerator SetTextUI()
    {
        textFinished = false;
        textLabel.text = "";

        //if (textList[index] == "G")
        //{
        //    faceImage.sprite = face01;
        //    index++;
        //    debug.log("头像加载成功code1");
        //}

        switch (textList[index])
        {
            case "A":
                faceImage.sprite = face01;
                index++;
                Debug.Log("switchloadingsuccess code1");
                //Debug.Log(faceImage.sprite);
                break;
            case "B":
                faceImage.sprite = face02;
                index++;
                Debug.Log("switchloadingsuccess code2");
                break;

            case "C":
                faceImage.sprite = face03;
                index++;
                Debug.Log("switchloadingsuccess code3");
                break;

            case "D":
                faceImage.sprite = face04;
                index++;
                Debug.Log("switchloadingsuccess code4");
                break;

            case "E":
                faceImage.sprite = face05;
                index++;
                Debug.Log("switchloadingsuccess code5");
                break;

            case "F":
                faceImage.sprite = face06;
                index++;
                Debug.Log("switchloadingsuccess code6");
                break;
                ;
            case "G":
                faceImage.sprite = face07;
                index++;
                Debug.Log("switchloadingsuccess code7");
                Debug.Log(faceImage.sprite);
                break;
            case "H":
                faceImage.sprite = face08;
                index++;
                Debug.Log("switchloadingsuccess code8");
                break;
            case "I":
                faceImage.sprite = face09;
                index++;
                Debug.Log("switchloadingsuccess code9");
                break;
            case "J":
                faceImage.sprite = face10;
                index++;
                Debug.Log("switchloadingsuccess code10");
                break;
            case "K":
                faceImage.sprite = face11;
                index++;
                Debug.Log("switchloadingsuccess code11");
                break;
            case "L":
                faceImage.sprite = face12;
                index++;
                Debug.Log("switchloadingsuccess code12");
                break;
            case "M":
                faceImage.sprite = face13;
                index++;
                Debug.Log("switchloadingsuccess code13");
                break;
            case "N":
                faceImage.sprite = face14;
                index++;
                Debug.Log("switchloadingsuccess code14");
                break;
        }

        if (audioON)
        {
            if (countnum == 0 && BOOL_AC0)
            {
                AudioSource.PlayClipAtPoint(AC0, faceImage.transform.position);
                Debug.Log("音频0加载成功");
            }
            if (countnum == 1 && BOOL_AC1)
            {
                AudioSource.PlayClipAtPoint(AC1, faceImage.transform.position);
                Debug.Log("音频1加载成功");
            }
            if (countnum == 2 && BOOL_AC2)
            {
                AudioSource.PlayClipAtPoint(AC2, faceImage.transform.position);
                Debug.Log("音频2加载成功");
            }
            if (countnum == 3 && BOOL_AC3)
            {
                AudioSource.PlayClipAtPoint(AC3, faceImage.transform.position);
                Debug.Log("音频3加载成功");
            }
            if (countnum == 4 && BOOL_AC4)
            {
                AudioSource.PlayClipAtPoint(AC4, faceImage.transform.position);
                Debug.Log("音频4加载成功");
            }
            if (countnum == 5 && BOOL_AC5)
            {
                AudioSource.PlayClipAtPoint(AC5, faceImage.transform.position);
                Debug.Log("音频5加载成功");
            }
            if (countnum == 6 && BOOL_AC6)
            {
                AudioSource.PlayClipAtPoint(AC5, faceImage.transform.position);
                Debug.Log("音频6加载成功");
            }
            if (countnum == 7 && BOOL_AC7)
            {
                AudioSource.PlayClipAtPoint(AC7, faceImage.transform.position);
                Debug.Log("音频7加载成功");
            }
            if (countnum == 8 && BOOL_AC8)
            {
                AudioSource.PlayClipAtPoint(AC8, faceImage.transform.position);
                Debug.Log("音频8加载成功");
            }
            if (countnum == 9 && BOOL_AC9)
            {
                AudioSource.PlayClipAtPoint(AC9, faceImage.transform.position);
                Debug.Log("音频9加载成功");
            }
            if (countnum == 10 && BOOL_AC10)
            {
                AudioSource.PlayClipAtPoint(AC10, faceImage.transform.position);
                Debug.Log("音频10加载成功");
            }

        }
        //for (int i = 0; i < textList[index].Length; i++)
        //{
        //    textLabel.text += textList[index][i];
        //    yield return new WaitForSeconds(textSpeed);
        //}
        int letter = 0;
        
        while(!cancelTyping && letter  < textList[index].Length - 1)
        {
          
            textLabel.text += textList[index][letter];
            letter++;
           
            yield return new WaitForSeconds(textSpeed);
        }
        textLabel.text = textList[index];
        cancelTyping = false;

        countnum++;
        
        textFinished = true; 
        index++;
        
    }
}
