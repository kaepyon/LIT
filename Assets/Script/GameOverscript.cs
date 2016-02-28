using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverscript : MonoBehaviour {
	public Button menu;
	public Button restart;

	public static string beforescenename;

	public void menuButton(){
		SceneManager.LoadScene ("Menu");
	}

	public void restartButton(){
		SceneManager.LoadScene (beforescenename);
	}
}
