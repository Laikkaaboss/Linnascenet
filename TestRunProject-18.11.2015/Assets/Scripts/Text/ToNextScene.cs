using UnityEngine;
using System.Collections;

public class ToNextScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {



	  StartCoroutine(waitti());
        Application.LoadLevel(Application.loadedLevel + 1);

	}



    IEnumerator waitti()
    {
        yield return new WaitForSeconds(10);
        Application.LoadLevel(Application.loadedLevel + 1);

    }
}
