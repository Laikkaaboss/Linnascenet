﻿using UnityEngine;
using System.Collections;

public class LastMenuScript : MonoBehaviour {

    public Camera ChosenCamera1;
    public MovieTexture movie1;

    void Start()
    {
        ChosenCamera1 = ChosenCamera1.GetComponent<Camera>();
    }
    void Update()
    {
        if (ChosenCamera1.enabled)
        {
            GetComponent<Renderer>().material.mainTexture = movie1 as MovieTexture;
            GetComponent<AudioSource>().clip = movie1.audioClip;
      
            movie1.loop = true;
            movie1.Play();
            
            StartCoroutine("waitForMovieEnd");
        }
    }
    IEnumerator waitForMovieEnd()
    {

        while (movie1.isPlaying) // while the movie is playing
        {
            yield return new WaitForEndOfFrame();
        }
        // after movie is not playing / has stopped.
        onMovieEnded();
    }

    void onMovieEnded()
    {
        Debug.Log("Movie Ended!");
  
    }
}
