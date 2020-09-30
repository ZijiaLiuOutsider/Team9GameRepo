using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class SceneScaleController : MonoBehaviour
{

    private float normalCameraSize;
    private float minCameraSize;
    private float maxCameraSize;

    private const float cScaleRange = 2f;             //场景缩放的最大范围
    private const float cScaleFactor = 0.05f;         //场景缩放的平滑速度

    private enum SceneScaleType { sstNone, sstShrink, sstEnlarge };
    private SceneScaleType scaleType = SceneScaleType.sstNone;

    private enum SceneScaleState { sssNormal, sssShrinked, sstEnlarged };
    private SceneScaleState scaleState = SceneScaleState.sssNormal;

    void Start()
    {
        normalCameraSize = Camera.main.orthographicSize;
        minCameraSize = normalCameraSize - cScaleRange;
        maxCameraSize = normalCameraSize + cScaleRange;
    }

    void Update()
    {
        if (scaleType == SceneScaleType.sstNone)
        {
            float factor = Input.GetAxis("Mouse ScrollWheel");
            if ((factor > 0) && (scaleState != SceneScaleState.sssShrinked))
            {
                scaleType = SceneScaleType.sstShrink;
            }
            else if ((factor < 0) && (scaleState != SceneScaleState.sstEnlarged))
            {
                scaleType = SceneScaleType.sstEnlarge;
            }
        }
        else if (scaleType == SceneScaleType.sstEnlarge)
        {
            float sz = Camera.main.orthographicSize;
            sz += cScaleFactor;

            if (scaleState == SceneScaleState.sssNormal)
            {
                if (sz >= maxCameraSize)
                {
                    sz = maxCameraSize;
                    scaleType = SceneScaleType.sstNone;
                    scaleState = SceneScaleState.sstEnlarged;
                }
                Camera.main.orthographicSize = sz;
            }
            else if (scaleState == SceneScaleState.sssShrinked)
            {
                if (sz >= normalCameraSize)
                {
                    sz = normalCameraSize;
                    scaleType = SceneScaleType.sstNone;
                    scaleState = SceneScaleState.sssNormal;
                }
                Camera.main.orthographicSize = sz;
            }
        }
        else if (scaleType == SceneScaleType.sstShrink)
        {
            float sz = Camera.main.orthographicSize;
            sz -= cScaleFactor;

            if (scaleState == SceneScaleState.sssNormal)
            {
                if (sz <= minCameraSize)
                {
                    sz = minCameraSize;
                    scaleType = SceneScaleType.sstNone;
                    scaleState = SceneScaleState.sssShrinked;
                }
                Camera.main.orthographicSize = sz;
            }
            else if (scaleState == SceneScaleState.sstEnlarged)
            {
                if (sz <= normalCameraSize)
                {
                    sz = normalCameraSize;
                    scaleType = SceneScaleType.sstNone;
                    scaleState = SceneScaleState.sssNormal;
                }
                Camera.main.orthographicSize = sz;
            }
        }
    }
}
