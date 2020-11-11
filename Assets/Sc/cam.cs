using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    public bool direction_x = false;//左右拖动
    public bool direction_y = false;//上下拖动
    public float CAM_Xspeed = 0.4f;//拖动速度
    public float CAM_Yspeed = 0.4f;


    void Update()
    {
        if (Input.GetMouseButton(1))//判断鼠标右键是否按下
        {
            //判断拖动类型并移动摄像机
            //如果XY方向同时开启则可以直接全方位移动 
            if (direction_x)
            {
                transform.Translate(Input.GetAxis("Mouse X") *  -CAM_Yspeed, 0, 0);
            }
            if (direction_y)
            {
                transform.Translate(0, Input.GetAxis("Mouse Y") * -CAM_Yspeed, 0);
            }
        }
    }
}
