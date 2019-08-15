using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SaveName : MonoBehaviour
{
    // Find the input field and grab the text thats been typed in
    public void submitName()
    {
        Debug.Log($"name {GameObject.FindWithTag("PlayerName").GetComponent<TMP_InputField()}>>");
        string name = GameObject.FindWithTag("PlayerName").GetComponent<InputField>().text;
        print("Saving " + name);
        Debug.Log($"I am {name}");
    }
}
