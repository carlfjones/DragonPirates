using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{

    public void LoadMainScene()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void PlayAgain()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

}
