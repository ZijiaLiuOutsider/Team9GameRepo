using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public GameObject prefab;
    public bool wdestroyed = false;

    private Vector2 startPos;
    /* static float x = Input.mousePosition.x;
     static float y = Input.mousePosition.y;
     static float z = 0;*/

    //Vector3 a = new Vector3(x, y, z); //实例化预制体的position，可自定义
    Quaternion b = new Quaternion(0, 0, 0, 0);
    Vector3 a = new Vector3(0, 0, 0); //实例化预制体的position，可自定义

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    public void Drag()
    {
        transform.position = Input.mousePosition;
    }

    public void BeginDrag()
    {
        transform.parent = GameObject.Find("Canvas").transform; 
    }

    public void EndDrag()
    {
            Destroy(gameObject);
            wdestroyed = true;
            GameObject Sphere = GameObject.Instantiate(prefab, a, b) as GameObject;

            float x = Camera.main.ScreenToWorldPoint(Input.mousePosition).x; //直接在鼠标最后的位置产生一个预制件
            float y = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;

            Sphere.transform.position = new Vector3(x, y, 0);

    }
    // Update is called once per frame


    public void OnMouseUp()
    {
       

    }

    public void Crt()
    {
        if (wdestroyed == true)
        {

        }
    }


    void Update()
    {
       
    }
 
}
