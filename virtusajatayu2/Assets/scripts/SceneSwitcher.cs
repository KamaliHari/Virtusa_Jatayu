using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using System.Diagnostics;


public class SceneSwitcher : MonoBehaviour
{
     public void playGame()
    {          
        SceneManager.LoadScene(sceneName:"SampleScene");
    }
}
