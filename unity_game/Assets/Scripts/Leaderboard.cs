using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Linq;


public class Leaderboard : MonoBehaviour
{

    public List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
    
     UnityEvent m_MyEvent = new UnityEvent();

    void Start(){
        Debug.Log("Running Leaderboard...");
        GenerateLeaderboard();
    }

    void Update(){
        GenerateLeaderboard();
    }

    public void OnClick()
    {
        string player_name = GameObject.Find("Text").GetComponent<Text>().text;
        ProcessLeaderboard(player_name, GameControl.instance.score);
    }

    public void ProcessLeaderboard(string name, int score){
        Debug.Log("Processing leaderboard");
        MainMenu.instance.list.Add(new KeyValuePair<string, int>(name, score));
        MainMenu.instance.list = MainMenu.instance.list.OrderBy(x => x.Value).ToList();
        MainMenu.instance.list.Reverse();
    }
    // Start is called before the first frame update
    public void GenerateLeaderboard()
    {   
        Debug.Log("Generating Leaderboard");
        int usernameVar = 1;
        foreach(var record in MainMenu.instance.list)
        {
            string usernameObject = "Name" + usernameVar;
            GameObject.Find(usernameObject).GetComponent<Text>().text = usernameVar.ToString() + ".  " + record.Key;
            usernameVar++;
            Debug.Log($"Leaderboard username object updated: {record.Key}");
        }

        int scoreVar = 1;
        foreach(var record in MainMenu.instance.list)
        {
            string scoreObject = "Score" + scoreVar;
            GameObject.Find(scoreObject).GetComponent<Text>().text = record.Value.ToString();
            scoreVar++;
            Debug.Log($"Leaderboard user score object updated: {record.Value}");
        }
    }
}
