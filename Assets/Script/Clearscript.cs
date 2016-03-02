using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Clearscript : MonoBehaviour {
	public Text text;
	float star;

	// Use this for initialization
	void Start () {
		star = Movescript.score;
		if (star >= 700) {
			text.text = "★★★";
		} else if (star < 700 && star >= 400) {
			text.text = "★★☆";
		} else if (star <= 100) {
			text.text = "";
		} else {
			text.text = "★☆☆";}
	}
}
