using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject cameraObject;
    private CameraController cameraController;

    private void Start()
    {
        cameraController = cameraObject.GetComponent<CameraController>();
    }

    public void Button1Click()
    {
        cameraController.SetCameraPosition1();
    }

    public void Button2Click()
    {
        cameraController.SetCameraPosition2();
    }
}
