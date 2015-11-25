using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class PlayMovieAndContinueslyGif : MonoBehaviour
{
    public Camera ChosenCamera1;
    public Camera nextCamera1;
    public MovieTexture movie1;
    void Start()
    {
        ChosenCamera1 = ChosenCamera1.GetComponent<Camera>();
        nextCamera1 = nextCamera1.GetComponent<Camera>();
        Debug.Log("rallatilei");
    }
    void Update()
    {
        if (ChosenCamera1.enabled)
        {
            Debug.Log("soittaa rallatilei");
            GetComponent<Renderer>().material.mainTexture = movie1 as MovieTexture;
            GetComponent<AudioSource>().clip = movie1.audioClip;
            movie1.Play();
            Debug.Log("´SOITTAAKO ?! : " + movie1.isPlaying);
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
        ChosenCamera1.enabled = !ChosenCamera1.enabled;
        nextCamera1.enabled = !nextCamera1.enabled;
    }
}
