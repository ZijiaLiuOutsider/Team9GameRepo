using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(AudioSource))]//绑定声音组件
public class test : MonoBehaviour
{
    private string s = "";//保存总文本内容
    string currentContent;//最新的文本内容
    public AudioClip clip;//系统消息音频
    public AudioClip yichang;//异常发现音频
    private AudioSource audio;
    Text t;
    string RichTextStart;//保存富文本的开头修饰符
    string RichTextEnd = "</size>" + "</color>";//富文本的结尾修饰符
    int newPos;//记录每一次文本播放完后的位置
    int pos;//切割文本的位置  上一次播放播放完后的位置
    void Start()
    {
        t = GetComponent<Text>();
        audio = GetComponent<AudioSource>();
        AddContent("系统消息：某日，天气晴，西北风2-3级", Color.blue, 30);
        AddCilp(clip);//添加 系统消息的音频
    }

    void Update()
    {
        //当newPos小于总文本长度
        if (newPos < s.Length)
        {
            //音频播放的进度和文字逐个出现的速度一样
            newPos = pos + (int)((audio.time / audio.clip.length) * currentContent.Length);//获取音频的播放平均速度乘文本的长度
            t.text = s.Substring(0, newPos) + RichTextEnd;


        }
        //当不播放音频时
        if (!audio.isPlaying)
        {
            t.text = s;//显示总文本内容
        }
        //按下空格
        if (Input.GetKeyDown(KeyCode.Space))
        {

            AddContent("异常发现", Color.red, 40);//添加文本 设置颜色和字号
            AddCilp(yichang);//添加异常发现音频

        }

    }
    /// <summary>
    /// 添加文本内容
    /// </summary>
    /// <param name="content">内容</param>
    /// <param name="color">颜色</param>
    /// <param name="size">字号</param>
    public void AddContent(string content, Color color, float size)
    {
        currentContent = content;//把添加的内容赋值给currentContent
        //                           可以获取颜色的十六进制的字符串
        RichTextStart = "<color=#" + ColorUtility.ToHtmlStringRGB(color) + ">" + "<size=" + size + ">";//富文本开头
        string text = RichTextStart + currentContent + RichTextEnd;//内容与富文本拼接
        s += text;//拼接好的内容赋值给总内容中 

    }
    /// <summary>
    /// 添加音频
    /// </summary>
    /// <param name="clip">音频片段</param>
    public void AddCilp(AudioClip clip)
    {
        //pos记录上一个文本播放完毕后的位置
        pos = s.Length - currentContent.Length - RichTextEnd.Length;
        audio.clip = clip;
        audio.Play();
    }
}