using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartEvent : MonoBehaviour
{

    public void StartApp()
    {
        SceneManager.LoadScene("OpenCvforComputer");
    }

}
