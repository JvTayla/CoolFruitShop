using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraController : MonoBehaviour
{
    public Vector3 position1 = new Vector3(0f, 0f, -10f);
    public Vector3 position2 = new Vector3(10f, 0f, -10f);

    public GameObject objectToDisable1;
    public GameObject objectToEnable1;

    public GameObject objectToDisable2;
    public GameObject objectToEnable2;

    public void SetCameraPosition1()
    {
        transform.position = position1;
        ToggleObjects(objectToDisable1, objectToEnable1);
    }

    public void SetCameraPosition2()
    {
        transform.position = position2;
        ToggleObjects(objectToDisable2, objectToEnable2);
    }

    private void ToggleObjects(GameObject objectToDisable, GameObject objectToEnable)
    {
        if (objectToDisable != null)
        {
            objectToDisable.SetActive(false); // Disable the first GameObject
        }

        if (objectToEnable != null)
        {
            objectToEnable.SetActive(true); // Enable the second GameObject
        }
    }
}



