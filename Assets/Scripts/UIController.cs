using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class UIController : MonoBehaviour {

	private float elapsedTime = 0; 
	private int i = 1;
	private string incomingSequence;

	public List<GameObject> openingUI = new List<GameObject>();

	// Use this for initialization
	void Start () {
		incomingSequence = "Opener";
	}
	
	// Update is called once per frame
	void Update () {
		elapsedTime += Time.deltaTime;

		Debug.Log(elapsedTime);

		if(incomingSequence == "Opener"){
			if(i >= openingUI.Count){
				incomingSequence = "FirstReminder";
				Color subtractor = new Color(0f, 0f, 0f, 0.000001f);
				while(openingUI[0].GetComponent<Image>().color[3] > 0){
					openingUI[0].GetComponent<Image>().color[3] -= .001f;
					for(int j = 1; j < openingUI.Count; j++){
						openingUI[j].GetComponent<Text>().color[3] -= .001f;
					}
				}


			}
			if(elapsedTime >= 1.5){
				openingUI[i].SetActive(true);
				elapsedTime = 0;
				i++;
			}
		}
	}

	void openingSequence () {

	}
}
