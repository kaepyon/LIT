using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movescript : MonoBehaviour {
	public GameObject maincamera;
	public Button right;
	public Button left;
	public Button back;
	public GameObject camera1;
	public GameObject camera2;
	private Text mission;
	float time=0;

	// Use this for initialization
	void Start () {	
		back.gameObject.SetActive (false);
		camera1.SetActive (false);
		camera2.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			int distance=100000;
			if (Physics.Raycast (ray, out hit, distance)) {
				Debug.DrawLine (ray.origin, hit.point, Color.red);
				if (hit.collider.tag == "Move1") {
					camera1.SetActive (true);
					maincamera.SetActive (false);
					right.gameObject.SetActive (false);
					left.gameObject.SetActive (false);
					back.gameObject.SetActive (true);
				}

				if (hit.collider.tag == "Move2") {
					camera2.SetActive (true);
					maincamera.SetActive (false);
					right.gameObject.SetActive (false);
					left.gameObject.SetActive (false);
					back.gameObject.SetActive (true);
				}

				if (hit.collider.tag == "Box") {
					
				}
			
				
				if (hit.collider.tag == "Enemy") {
					hit.collider.SendMessage ("Damage");
				}
			}
		}

		GameObject clock = GameObject.FindGameObjectWithTag ("Enemy").gameObject;
		Debug.Log (clock.name);

		if(clock != null){
			time += Time.deltaTime;
			Debug.Log ("2");
			if (time >= 10) {
				GameOverscript.beforescenename=Application.loadedLevelName;
				SceneManager.LoadScene("GameOver");
			}
		}
	}

	public void rightButton(){
		maincamera.transform.localEulerAngles += new Vector3 (0, 90, 0);
	}

	public void leftButton(){
		maincamera.transform.localEulerAngles += new Vector3 (0, 270, 0);
	}

	public void backButton(){
		maincamera.SetActive (true);
		camera1.SetActive (false);
		camera2.SetActive (false);
		back.gameObject.SetActive (false);
		right.gameObject.SetActive (true);
		left.gameObject.SetActive (true);
	}
	//vector3 lerp
}

