﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menuscript : MonoBehaviour {
	public Button stage;

	void Update(){
	
	}

	public void stageButton(){
		SceneManager.LoadScene("Main1");
	}


}
