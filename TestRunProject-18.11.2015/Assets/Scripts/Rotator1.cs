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
		transform.Rotate(new Vector3(2, 2,2 ) * Time.deltaTime);
	}
}