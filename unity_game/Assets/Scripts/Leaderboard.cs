using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour
{
    // Start is called before the first frame update
    public void GenerateLeaderboard()
    {
        var list = new List<KeyValuePair<string, int>>();

        list.Add(new KeyValuePair<string, int>("Remy", 100));
        list.Add(new KeyValuePair<string, int>("Chris", 80));
        list.Add(new KeyValuePair<string, int>("Jake", 60));
        list.Add(new KeyValuePair<string, int>("Stig", 150));

        int usernameVar = 1;
        foreach(var record in list)
        {
            string usernameObject = "Name" + usernameVar;
            GameObject.Find(usernameObject).GetComponent<Text>().text = usernameVar.ToString() + ".  " + record.Key;
            usernameVar++;
            Debug.Log($"Leaderboard username object updated: {record.Key}");
        }

        int scoreVar = 1;
         foreach(var record in list)
         {
             string scoreObject = "Score" + scoreVar;
             GameObject.Find(scoreObject).GetComponent<Text>().text = record.Value.ToString();
             scoreVar++;
             Debug.Log($"Leaderboard user score object updated: {record.Value}");
         }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
