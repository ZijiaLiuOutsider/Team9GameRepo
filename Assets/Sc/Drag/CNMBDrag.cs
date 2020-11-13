using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
public class CNMBDrag : MonoBehaviour
{
    private Vector2 startPos;
    public GameObject CNM;
    [SerializeField] private Transform correctTrans;//黑色图片位置信息
    public GameObject CNM1;
    [SerializeField] private Transform correctTrans1;//黑色图片位置信息
    public GameObject CNM2;
    [SerializeField] private Transform correctTrans2;//黑色图片位置信息
    public GameObject CNM3;
    [SerializeField] private Transform correctTrans3;//黑色图片位置信息
    public GameObject CNM4;
    [SerializeField] private Transform correctTrans4;//黑色图片位置信息
    public GameObject CNM5;
    [SerializeField] private Transform correctTrans5;//黑色图片位置信息
    public GameObject CNM6;
    [SerializeField] private Transform correctTrans6;//黑色图片位置信息
    public GameObject CNM7;
    [SerializeField] private Transform correctTrans7;//黑色图片位置信息
    public GameObject CNM8;
    [SerializeField] private Transform correctTrans8;//黑色图片位置信息


    public bool POS = false;
    public bool POS1 = false;
    public bool POS2 = false;
    public bool POS3 = false;
    public bool POS4 = false;
    public bool POS5 = false;
    public bool POS6 = false;
    public bool POS7 = false;
    public bool POS8 = false;
    public bool POS9 = false;

    [SerializeField] private bool isFinished;//如果位置正确再也不能拖拽物体

    public GameObject UIperfab;

    private float hx;
    private float hy;
    private float hz;

    public float zx;
    public float zy;//原先参数传递有点问题（搞不懂）就直接设定目标位置好了

    private bool PANDING;//用于判定是场景中物体还是UI中产生的物体
    private float number = 0;

    Quaternion b = new Quaternion(0, 0, 0, 0);
    Vector3 a = new Vector3(0, 0, 0); //实例化预制体的position，可自定义

    private void Start()
    // Start is called before the first frame update
    {
        startPos = transform.position;

        if (zx == 0 || zy == 0)
        {
            PANDING = false;
        }
        else
        {
            PANDING = true;
        }
        //hx = transform.Find("Card_2").gameObject.GetComponent<GetPosition>().tx;
        //hy = transform.Find("Card_2").gameObject.GetComponent<GetPosition>().ty;

    }

    private void OnMouseDrag() //如果要在达到确定位置后不可移动将//@注释删除
    {
        //@if(isFinished ==  false )
        //@{
        transform.position = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
                                         Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        //@}


    }

    private void OnMouseUp()
    //拖拽的图片离着目标点太远则返回初始位置
    //当拖着物体到达指定位置（2这者之间的相对距离小到一个程度的时候）判定到达指定位置，固定到正确位置
    {
        if (PANDING == true)
        {
            if (Mathf.Abs(transform.position.x - zx) <= 2.0f &&
                Mathf.Abs(transform.position.y - zy) <= 2.0f)
            {
                transform.position = new Vector2(zx, zy);
                number = 0;
                SceneManager.LoadScene("2-18");
                Debug.Log("correct place...");

            }
            else
            {
                transform.position = new Vector2(startPos.x, startPos.y);
                number++;
            }
        }
        else if (PANDING == false)
        {
            if (Mathf.Abs(transform.position.x - correctTrans.position.x) <= 2.0f &&
                Mathf.Abs(transform.position.y - correctTrans.position.y) <= 2.0f)
            {
                transform.position = new Vector2(correctTrans.position.x, correctTrans.position.y);
                number = 0;
                //SceneManager.LoadScene("2-18");
                POS = true;
                CNM.SetActive(true);
                Debug.Log("correct place...");
      
                //@isFinished = true;
            }

            else if (Mathf.Abs(transform.position.x - correctTrans1.position.x) <= 2.0f &&
                Mathf.Abs(transform.position.y - correctTrans1.position.y) <= 2.0f)
            {
                transform.position = new Vector2(correctTrans1.position.x, correctTrans1.position.y);
                number = 0;
                //SceneManager.LoadScene("2-18");
                POS1 = true;
                CNM1.SetActive(true);
                Debug.Log("correct place...");
             
                //@isFinished = true;
            }

            else if (Mathf.Abs(transform.position.x - correctTrans2.position.x) <= 2.0f &&
                Mathf.Abs(transform.position.y - correctTrans2.position.y) <= 2.0f)
            {
                transform.position = new Vector2(correctTrans2.position.x, correctTrans2.position.y);
                number = 0;
                //SceneManager.LoadScene("2-18");
                POS2 = true;
                CNM2.SetActive(true);
                Debug.Log("correct place...");
        
                //@isFinished = true;
            }
           
            else if (Mathf.Abs(transform.position.x - correctTrans3.position.x) <= 2.0f &&
            Mathf.Abs(transform.position.y - correctTrans3.position.y) <= 2.0f)
            {
                transform.position = new Vector2(correctTrans3.position.x, correctTrans3.position.y);
                number = 0;
                //SceneManager.LoadScene("2-18");
                POS3 = true;
                CNM3.SetActive(true);
                Debug.Log("correct place...");
        
                //@isFinished = true;
            }
           
           else  if (Mathf.Abs(transform.position.x - correctTrans4.position.x) <= 2.0f &&
            Mathf.Abs(transform.position.y - correctTrans4.position.y) <= 2.0f)
            {
                transform.position = new Vector2(correctTrans4.position.x, correctTrans4.position.y);
                number = 0;
                //SceneManager.LoadScene("2-18");
                POS4= true;
                CNM4.SetActive(true);
                Debug.Log("correct place...");
             
                //@isFinished = true;
            }
           
           else  if (Mathf.Abs(transform.position.x - correctTrans5.position.x) <= 2.0f &&
           Mathf.Abs(transform.position.y - correctTrans5.position.y) <= 2.0f)
            {
                transform.position = new Vector2(correctTrans5.position.x, correctTrans5.position.y);
                number = 0;
                //SceneManager.LoadScene("2-18");
                POS5 = true;
                CNM5.SetActive(true);
                Debug.Log("correct place...");
                //@isFinished = true;
            }
        

            else if (Mathf.Abs(transform.position.x - correctTrans6.position.x) <= 2.0f &&
                Mathf.Abs(transform.position.y - correctTrans6.position.y) <= 2.0f)
            {
                transform.position = new Vector2(correctTrans6.position.x, correctTrans6.position.y);
                number = 0;
                //SceneManager.LoadScene("2-18");
                POS6 = true;
                CNM6.SetActive(true);
                Debug.Log("correct place...");
                //@isFinished = true;
            }

            else if (Mathf.Abs(transform.position.x - correctTrans7.position.x) <= 2.0f &&
                Mathf.Abs(transform.position.y - correctTrans7.position.y) <= 2.0f)
            {
                transform.position = new Vector2(correctTrans7.position.x, correctTrans7.position.y);
                number = 0;
                //SceneManager.LoadScene("2-18");
                POS7 = true;
                CNM7.SetActive(true);
                Debug.Log("correct place...");
                isFinished = true;
                //@isFinished = true;
            }

            else if (Mathf.Abs(transform.position.x - correctTrans8.position.x) <= 2.0f &&
                Mathf.Abs(transform.position.y - correctTrans8.position.y) <= 2.0f)
            {
                transform.position = new Vector2(correctTrans8.position.x, correctTrans8.position.y);
                number = 0;
                //SceneManager.LoadScene("2-18");
                POS8 = true;
                CNM8.SetActive(true);
                Debug.Log("correct place...");
                isFinished = true;
                //@isFinished = true;
            }

     
                transform.position = new Vector2(startPos.x, startPos.y);
                number++;
            

            if(POS&& POS1 && POS2 && POS3 && POS4 && POS5 && POS6 && POS7 && POS8)
            {
                SceneManager.LoadScene("2-20");
            }
        }


        /* if (number >= 3)         //如果在两次之内未找到正确位置，则直接回到原来位置
         {
             Destroy(gameObject);
             GameObject ui = Instantiate(UIperfab, new Vector3(0, 0, 0), Quaternion.identity, transform);
         }
        if (Input.GetMouseButtonDown(2))
                {
                    Destroy(gameObject);
                }
         */
    }
}