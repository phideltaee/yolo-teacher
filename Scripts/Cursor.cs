using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenCVForUnity.UnityUtils;
using OpenCVForUnity.UnityUtils.Helper;
using OpenCVForUnity.CoreModule;

public class Cursor : MonoBehaviour
{

    private float x;
    private float y;
    public int radius;
    private bool isTrigger;

    // Start is called before the first frame update
    void Start()
    {
        WebCamTextureToMatHelper webCamTextureToMatHelper = gameObject.GetComponent<WebCamTextureToMatHelper>();
        Mat webCamTextureMat = webCamTextureToMatHelper.GetMat();
        x = webCamTextureMat.width()/2;
        y = webCamTextureMat.height()/2;
        isTrigger = false;
    }

    public float Getx()
    {
        return x;
    }
    public float Gety()
    {
        return y;
    }

}
