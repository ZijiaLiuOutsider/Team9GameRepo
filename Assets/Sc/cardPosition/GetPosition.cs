using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPosition : MonoBehaviour
{
    public float tx;
    public float ty;
    public float tz;

    // Start is called before the first frame update
    void Start()
    {
        tx = transform.position.x;
        ty = transform.position.y;
        tz = transform.position.z;

        Debug.Log(tx);
        Debug.Log(ty);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
