using UnityEngine;
using System.Collections;

public class CameChangeNewMenu : MonoBehaviour
{
    public Camera FourthCamera;
   // public Canvas canvas;
    public Canvas ThirdCanvas;

    // public GUITexture guiTextureCamp;

    // Use this for initialization
    void Start()
    {
       // canvas = canvas.GetComponent<Canvas>();
      
        FourthCamera = FourthCamera.GetComponent<Camera>();

        ThirdCanvas = ThirdCanvas.GetComponent<Canvas>();
     //  guiTextureCamp.enabled = false;
     //   canvas.enabled = false;
        FourthCamera.enabled = true;
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

