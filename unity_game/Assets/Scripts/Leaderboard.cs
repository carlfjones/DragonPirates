using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Linq;
public class Leaderboard : MonoBehaviour
{

    UnityEvent m_MyEvent = new UnityEvent();
    public string QuoteRandomiser()
        {
            string[] quoteList = new string[]{
                "Be shore of yourself.",
                "Let your worries drift away.",
                "Don’t coast through life.",
                "Drown out pier pressure.",
                "Sea’s life’s moments.",
                "Come shell or high water.",
                "Ride the waves.",
                "Be who you arrrr.",
                "Beware the cor-pirate ladder.",
                "Don’t be arrr-ogant.",
                "Always buy your goods on sail.",
                "Don’t be a nervous wreck!",
                "Everything in moderation, don’t go overboard!",
                "Recklessness may cost you an arm and a leg",
                "If you go to war, make sure you bring an arrr-my",
                "Keep going, yarrrr doing great!",
                "Im going to yoga, arr"
            };
            System.Random rand = new System.Random();
            int index = rand.Next(quoteList.Length);
            return quoteList[index];
        }

    public void OnClick()
    {
        string player_name = GameObject.Find("Text").GetComponent<Text>().text;
        GameObject.Find("Name").GetComponent<Text>().text = player_name + ",";
        GameObject.Find("InputField").SetActive(false);
        GenerateLeaderboard();
    }

    public void GenerateLeaderboard()
    {
        Debug.Log("Generating Leaderboard");
        GameObject.Find("Quote").GetComponent<Text>().text = QuoteRandomiser();
    }
}
