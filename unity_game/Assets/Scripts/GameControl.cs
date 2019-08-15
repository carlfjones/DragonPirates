using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    //Singleton:
    public static GameControl instance;
    public GameObject gameOverText;
    public GameObject quitButton;
    public Text scoreText;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

    //public GameObject archer2;


    private int score = 0;

    // Use this for initialization
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy (gameObject);
        }
    }

    void Update()
    {
        if (gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void DragonScored()
    {
        if (gameOver)
        {
             return;
        }
        score++;
        scoreText.text = "Score: " + score.ToString ();
    }

    public void DragonDied()
    {

        gameOverText.SetActive(true);

        // quitButton.SetActive(true);

        gameOver = true;
        IEnumerator Wait(){
          yield return new WaitForSeconds (3.0f);
        SceneManager.LoadScene("EndGame");
      }
    }

}
