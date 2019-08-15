using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Quit : MonoBehaviour
{
    public Text finalScore;

    void Update()
    {
    // finalScore.text = PlayerPrefs.GetInt("Score: ").ToString();
    finalScore.text = GameControl.instance.score.ToString();
    }


    public void LoadMainScene()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void PlayAgain()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

}
