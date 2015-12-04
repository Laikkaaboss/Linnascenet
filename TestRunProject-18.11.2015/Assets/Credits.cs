using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {
    public GameObject camera;
    public int speed = 1;

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
        camera.transform.Translate(Vector3.down * Time.deltaTime * speed);
        StartCoroutine(waitFor());
                }
    IEnumerator waitFor(){
        yield return new WaitForSeconds(50);
        Application.LoadLevel(0);
        
        }
}
