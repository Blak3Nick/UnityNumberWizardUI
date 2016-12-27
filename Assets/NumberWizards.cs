using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizards : MonoBehaviour {
	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 15;
	public Text text;
	// Use this for initialization
	void Start () {
		StartGame();
	}
	void StartGame() {
		max = 1000;
		min = 1;
		guess = 500;		 		
	}
	void NextGuess() {
		guess = Random.Range (min, max+1);	
		text.text = guess.ToString();
		maxGuessesAllowed --;
		if (maxGuessesAllowed <=0) {
		Application.LoadLevel("Lose");
		}	
	}

	public void GuessHigher(){
		min = guess;
		NextGuess();
	}
	public void GuessLower(){
		max = guess;
		NextGuess();
	}
}
