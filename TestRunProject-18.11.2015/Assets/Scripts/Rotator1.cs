using UnityEngine;
using System.Collections;
public class Rotator1 : MonoBehaviour
{
	// Use this for initialization
	void Start()
	{
	}
	// Update is called once per frame
	void Update()
	{
		transform.Rotate(new Vector3(15, 15,15 ) * Time.deltaTime);
	}
}