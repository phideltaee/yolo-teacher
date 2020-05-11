using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenCVForUnity.UnityUtils;
using OpenCVForUnity.UnityUtils.Helper;
using OpenCVForUnity.CoreModule;

public class Cursor : MonoBehaviour
{
    public GameObject quad;
    private float x;
    private float y;
    public int radius;
    private bool isTrigger;

    // Start is called before the first frame update
    void Start()
    {
        WebCamTextureToMatHelper webCamTextureToMatHelper = quad.GetComponent<WebCamTextureToMatHelper>();
        x = webCamTextureToMatHelper.requestedWidth / 2;
        y = webCamTextureToMatHelper.requestedHeight /2;

    }

    public float Getx()
    {
        return x;
    }
    public float Gety()
    {
        return y;
    }
    public void SetisTrigger(bool _state)
    {
        isTrigger = _state;
        this.gameObject.SetActive(isTrigger);
    }

}
