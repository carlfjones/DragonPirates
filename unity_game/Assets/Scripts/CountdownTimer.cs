using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{

   float currentTime = 0f;
   float startingTime = 3f;
   [SerializeField] Text countdownText;

   // Start is called before the first frame update
   void Start()
   {
       currentTime = startingTime;
   }
   
   // Update is called once per frame
   void Update()
   {
       currentTime -= 1 * Time.deltaTime;
       countdownText.text = currentTime.ToString("0");
       if(currentTime <= 1)
       {
           countdownText.text = "GO!";
       }
       if(currentTime <= 0){
           countdownText.gameObject.SetActive(false);
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
       }
   }
}


