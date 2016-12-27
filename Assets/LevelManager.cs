﻿using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
	Debug.Log("Level load requested"+name);
		Application.LoadLevel(name);
	}
	public void QuitLevel(){
		Debug.Log("Level quit requested");
		Application.Quit();
	}
}
