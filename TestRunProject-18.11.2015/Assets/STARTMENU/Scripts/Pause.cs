using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Pause : MonoBehaviour {
	
	public GameObject Canvas;
	//public GameObject Camera;
	bool Paused = false;
	
	void Start(){
		bool Paused = true;
		Canvas.gameObject.SetActive (false);
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (Paused){
				Time.timeScale = 0;
				Canvas.gameObject.SetActive (true);
			}
			else{
				Time.timeScale = 1;
				Canvas.gameObject.SetActive (false);
			}
			Paused = !Paused;
		}
	}
	public void Resume(){
		Time.timeScale = 1.0f;
		Canvas.gameObject.SetActive (false);
	//	Cursor.visible = false;
	//	Screen.lockCursor = true;
	//	Camera.GetComponent<AudioSource>().Play ();
		Paused = !Paused;
	}
}    
