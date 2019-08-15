using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // access the InputFieldComponent for the object linked to this script(i.e., InputField)
        // use the event onEndEdit, which means that we will be tracking when the user has finished editing his/her text.
        // When this happens, we will call a function called displayText 
        Debug.Log($"input field: {gameObject.GetComponent<InputField>()}");
        gameObject.GetComponent<InputField>().onEndEdit.AddListener(displayText);
    }

    private void displayText(string textInField)
    {
        print(textInField);
    }
}
