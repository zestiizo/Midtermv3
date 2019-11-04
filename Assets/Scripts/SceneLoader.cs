using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //loads level
    public void LoadGameScene()
    {
        SceneManager.LoadScene("MainLevel");
    }
}
