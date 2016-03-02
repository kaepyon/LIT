using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boxscript : MonoBehaviour {
	public GameObject box;
	public Button decide;
	public Button cancel;
	public InputField field;
	public Button right;
	public Button left;
	string str;


	void Start(){
		decide.gameObject.SetActive (false);
		cancel.gameObject.SetActive (false);
		field.gameObject.SetActive (false);
	}

	void Update(){
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			int distance=100000;
			if (Physics.Raycast (ray, out hit, distance)) {
				Debug.DrawLine (ray.origin, hit.point, Color.red);
				if (hit.collider.tag=="Box") {
					decide.gameObject.SetActive (true);
					cancel.gameObject.SetActive (true);
					field.gameObject.SetActive (true);
					right.gameObject.SetActive (false);
					left.gameObject.SetActive (false);
				}
			}
		}
	}

	public void judgeButton(){
		str = field.text;
		if (str == "617") {
			SceneManager.LoadScene("Clear");
		}
	}

	public void cancelButton(){
		right.gameObject.SetActive (true);
		left.gameObject.SetActive (true);
		decide.gameObject.SetActive (false);
		cancel.gameObject.SetActive (false);
		field.gameObject.SetActive (false);		
	}

}
