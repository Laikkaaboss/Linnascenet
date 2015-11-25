using UnityEngine;
using System.Collections;

[RequireComponent (typeof(AudioSource))]

public class PlayMovie : MonoBehaviour {
    public Camera ChosenCamera;
    public Camera nextCamera;
    public MovieTexture movie;
    void Start()
    {
        ChosenCamera = ChosenCamera.GetComponent<Camera>();
        nextCamera = nextCamera.GetComponent<Camera>();
        Debug.Log("Seasddsasdttaa ads");
    }
    void Update()
    {
        if (ChosenCamera.enabled)
        {
            Debug.Log("soittaa ads");
            GetComponent<Renderer>().material.mainTexture = movie as MovieTexture;
            GetComponent<AudioSource>().clip = movie.audioClip;
            movie.Play();
            StartCoroutine("waitForMovieEnd");
        }
    }
    IEnumerator waitForMovieEnd()
    {

        while (movie.isPlaying) // while the movie is playing
        {
            yield return new WaitForEndOfFrame();
        }
        // after movie is not playing / has stopped.
        onMovieEnded();
    }

    void onMovieEnded()
    {
        Debug.Log("Movie Ended!");
        ChosenCamera.enabled = !ChosenCamera.enabled;
        nextCamera.enabled = !nextCamera.enabled;

    }

        }
    

