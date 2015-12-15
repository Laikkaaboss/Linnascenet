using UnityEngine;
using System.Collections;

public class UnlockMouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Cursor.lockState = CursorLockMode.None;
        UnityEngine.Cursor.visible = true;
    }
}
