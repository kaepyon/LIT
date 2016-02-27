using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Startscript : MonoBehaviour {
	public Button start;

	public void startButton(){
		Application.LoadLevel ("Main");
	}
}
