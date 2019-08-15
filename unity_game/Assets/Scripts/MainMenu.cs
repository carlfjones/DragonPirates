using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static MainMenu instance;

    public List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
    public string player_name;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        InputField ifg = gameObject.GetComponent<InputField>();
        Debug.Log($"THIS IS THE VALUE OF IFG <<<<{ifg}>>>>>");
        var listenEvent = new InputField.SubmitEvent();
        // listenEvent.AddListener(PlayGame);
        // ifg.onEndEdit = listenEvent;
    }

    void PlayGame()
    {
        Debug.Log("im inside");
        // name = gameObject.FindWithTag("playername").GetComponent<Text>();
        player_name = "Player";
        // Debug.Log($"This is the name {name}");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
