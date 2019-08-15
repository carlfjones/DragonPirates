using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// using TMPro;

public class MainMenu : MonoBehaviour
{
    public static MainMenu instance;
    

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }



    void PlayGame()
    {
        // ifg = GameObject.Find("Text");
        // Debug.Log($"THIS IS THE VALUE OF IFG <<<<{ifg}>>>>>");
        // string name = ifg.GetComponent<Text>().text;
        // Debug.Log($"MY Name IS <<<<{name}>>>>>");
       
        // Debug.Log("im inside");
        // // name = gameObject.FindWithTag("playername").GetComponent<Text>();
        // player_name = "Player";
        // Debug.Log($"This is the name {name}");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
