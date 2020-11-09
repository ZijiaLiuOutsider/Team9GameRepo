using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
public class LightDrag : MonoBehaviour
{
    private Vector2 startPos;
    [SerializeField] private Transform correctTrans;//黑色图片位置信息
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
                SceneManager.LoadScene("2-11");
                Debug.Log("correct place...");
                isFinished = true;
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
                SceneManager.LoadScene("2-11");
                Debug.Log("correct place...");
                isFinished = true;
                //@isFinished = true;
            }
            else
            {
                transform.position = new Vector2(startPos.x, startPos.y);
                number++;
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