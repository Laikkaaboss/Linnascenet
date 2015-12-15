using UnityEngine;
using System.Collections;

public class PlayMenuMussicNewMenu : MonoBehaviour {


   // public Camera ChosenCamera1;
    public Camera ChosenCamera12;
    //public AudioClip audio;
    // Use this for initialization
    AudioSource audio;
    void Start()
    {
       // ChosenCamera1 = ChosenCamera1.GetComponent<Camera>();
        ChosenCamera12 = ChosenCamera12.GetComponent<Camera>();
          //audio = GetComponent<AudioSource>();
        // audio.Stop();
    }

    // Update is called once per frame
    void Update()
    {

        audio = GetComponent<AudioSource>();
        if (ChosenCamera12.enabled == true)
        {
            // GetComponent<Renderer>().material.mainTexture = movie1 as MovieTexture;
            if (!audio.isPlaying)
            {
                Debug.Log("alko soittaa");
                audio.Play();
            }

            //StartCoroutine("waitForMovieEnd");
        }
        else
        {
            audio.Stop();
        }
    }

}
