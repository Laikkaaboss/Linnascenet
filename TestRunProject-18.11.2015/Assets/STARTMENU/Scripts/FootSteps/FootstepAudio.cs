using UnityEngine;
using System.Collections;

// FootstepAudio.cs & AudioColliderType.cs
// Written by Mike Cannell, Altrius Ltd.
// http://altri.us
// YouTube instructions: http://youtu.be/yTCIbfH03GQ
// August 19, 2014

// This script assumes that it is attached to an object that uses the Mechanim
// Animation system and uses Animation Events to call the functions below.
// See Youtube video for detailed instructions on how to do this
// Must be used with AudioColliderType.cs attached to an object your character will walk on

public class FootstepAudio : MonoBehaviour {

//Setup the public variables in the inspector so the user
//can drag the custom audio files to the variables.
//Adding different sound options is easy, just add a new line
//Example: public AudioClip mudSound;
//Just make sure you add the options for MUD in the other script and 
//below in the PlayStepSound function
public AudioClip grassSound;
public AudioClip waterSound;
public AudioClip woodSound;
public AudioClip snowSound;
public AudioClip gravelSound;
public AudioClip metalSound;
public AudioClip plasticSound;
public AudioClip jumpSound;

//Setup the private variable that handles the collider type communication between the
//two scripts: this one and AudioColliderType.cs
private string colliderType;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//This collider script handles the detection between an object and 
	//a character that has the CharacterController component attached to it.
	//Example: the main player that uses keyboard/joystick input
	void OnControllerColliderHit (ControllerColliderHit col){
		//Once a collision is detected, check to see if the object that collided with
		//this object has the AudioColliderType component attached to it (our other script)
		if(col.gameObject.GetComponent<AudioColliderType>()){
			//set the colliderType variable to the "type" set in the 
			//AudioColliderType component in the Inspector
			//GetTerrainType() returns a string, you could use less code by using the
			//the enumeration values but this allows you to see the type rather than just a number
			colliderType = col.gameObject.GetComponent<AudioColliderType>().GetTerrainType();
		}
	}

	//This collider script handles the detection between an object and 
	//another object that DOES NOT have the CharacterController component attached to it.
	//Example: AI that doesn't use input, any type of GameObject
	void OnCollisionEnter (Collision col){
		//Once a collision is detected, check to see if the object that collided with
		//this object has the AudioColliderType component attached to it (our other script)
		if(col.gameObject.GetComponent<AudioColliderType>()){
			//set the colliderType variable to the "type" set in the 
			//AudioColliderType component in the Inspector
			//GetTerrainType() returns a string, you could use less code by using the
			//the enumeration values but this allows you to see the type rather than just a number
			colliderType = col.gameObject.GetComponent<AudioColliderType>().GetTerrainType();
		}
	}


	//Function that is called by the Animation Event in the Animations Inspector.
	//Call PlayStepSound when a humanoid's foot touches the ground using an Animation Event
	void PlayStepSound(){
		//Grab the string value of the variable, colliderType, and play
		//the corresponding audio file. A switch statement replaces
		//a long string of if/then statements, it's like saying
		//if(colliderType == "Grass"){
		switch(colliderType){
		case "Grass":
			GetComponent<AudioSource>().PlayOneShot(grassSound);
			break;
		case "Water":
			GetComponent<AudioSource>().PlayOneShot(waterSound);
			break;
		case "Wood":
			GetComponent<AudioSource>().PlayOneShot(woodSound);
			break;
		case "Snow":
			GetComponent<AudioSource>().PlayOneShot(snowSound);
			break;
		case "Gravel":
			GetComponent<AudioSource>().PlayOneShot(gravelSound);
			break;
		case "Metal":
			GetComponent<AudioSource>().PlayOneShot(metalSound);
			break;
		case "Plastic":
			GetComponent<AudioSource>().PlayOneShot(plasticSound);
			break;
			
		}
	}


	//Function that is called by the Animation Event in the Animations Inspector.
	//Call PlayJumpSound when a humanoid begins the jump animation using an Animation Event
	void PlayJumpSound(){
		GetComponent<AudioSource>().PlayOneShot(jumpSound);
	}


}


	