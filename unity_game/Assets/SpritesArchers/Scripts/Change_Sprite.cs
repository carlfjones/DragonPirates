using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Sprite : MonoBehaviour {

	public GameObject[] Archers;
	public int currentArcher = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			/*Archers [0].SetActive (false);
			Archers [1].SetActive (false);
			Archers [2].SetActive (false);

			currentArcher+=1;*/
			foreach (GameObject i in Archers) {
				
				i.SetActive (false);
			}
			currentArcher+=1;
			if (currentArcher > (Archers.Length-1)) {
				currentArcher = 0;
			}
			Archers [currentArcher].SetActive (true);	
			
		}
	}
}
