using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartEvent : MonoBehaviour
{
   
    public void StartApp(string _nameScene)
    {
        SceneManager.LoadScene(_nameScene);
    }

}
