using UnityEngine;
using System.Collections;

public class CameraChange : MonoBehaviour
{
    public Camera FirstCamera;
    public Camera SecondCamera;
    public Camera MainCamera;
    public Camera FourthCamera;
    public Canvas canvas;
    public Canvas FirstCanvas;
    public Canvas SecondCanvas;
    public Canvas ThirdCanvas;

   // public GUITexture guiTextureCamp;

    // Use this for initialization
    void Start()
    {
        canvas = canvas.GetComponent<Canvas>();
        FirstCamera = FirstCamera.GetComponent<Camera>();
        SecondCamera = SecondCamera.GetComponent<Camera>();
        MainCamera = MainCamera.GetComponent<Camera>();
        FourthCamera = FourthCamera.GetComponent<Camera>();

        FirstCanvas = FirstCanvas.GetComponent<Canvas>();
        SecondCanvas = SecondCanvas.GetComponent<Canvas>();
        ThirdCanvas = ThirdCanvas.GetComponent<Canvas>();
      //  guiTextureCamp.enabled = false;
        canvas.enabled = false;
        FirstCanvas.enabled = true;
        ThirdCanvas.enabled = false;
        SecondCanvas.enabled = false;
        FirstCamera.enabled = true;
        SecondCamera.enabled = false;
        MainCamera.enabled = false;
        FourthCamera.enabled = false;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            FirstCamera.enabled = !FirstCamera.enabled;
            SecondCamera.enabled = !SecondCamera.enabled;
            FirstCanvas.enabled = !FirstCanvas.enabled;
            SecondCanvas.enabled = !SecondCanvas.enabled; 
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            SecondCamera.enabled = !SecondCamera.enabled;
            MainCamera.enabled = !MainCamera.enabled;
            canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            SecondCanvas.enabled = !SecondCanvas.enabled; 
            ThirdCanvas.enabled = !ThirdCanvas.enabled;
      
         //   guiTextureCamp.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            MainCamera.enabled = !MainCamera.enabled;
            FourthCamera.enabled = !FourthCamera.enabled;

        }
        if (MainCamera.enabled == true)
        {
            canvas.enabled = true;
        }
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
