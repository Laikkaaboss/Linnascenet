using UnityEngine;
using System.Collections;

public class GAMEOVER : MonoBehaviour
{
    public Camera MainCamera;
    public Canvas canvas;


    // public GUITexture guiTextureCamp;

    // Use this for initialization
    void Start()
    {
        canvas = canvas.GetComponent<Canvas>();
      
        MainCamera = MainCamera.GetComponent<Camera>();
 

       
        //  guiTextureCamp.enabled = false;
        canvas.enabled = true;
        MainCamera.enabled = false;
       
    }
    void Update()
    {

        //public void ShowFirstCamera(){
        //    FirstCamera.enabled = true;
        //    SecondCamera.enabled = false;
        //    MainCamera.enabled = false;
        //}
        //public void ShowSecondCamera()
        //{
        //    FirstCamera.enabled = false;
        //    SecondCamera.enabled = true;
        //    MainCamera.enabled = false;
        //}
        //public void ShowThirdCamera()
        //{
        //    FirstCamera.enabled = false;
        //    SecondCamera.enabled = false;
        //    MainCamera.enabled = true;
        //}

    }
}

