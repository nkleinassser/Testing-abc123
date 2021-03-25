using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{
    float rotateX = 0.0f;
    float rotateY = 0.0f;
    float rotateZ = 0.0f;
    float rotateDeltaX = 0.0f;
    float rotateDeltaY = 0.0f;
    float rotateDeltaZ = 0.0f;

    GameObject mainCamera;

    void Start()
    {
        mainCamera = new GameObject("Camera");
        mainCamera.name = "mainCamera";

        mainCamera.GetComponent<Transform>().position = new Vector3(0, 15, 0);
        mainCamera.GetComponent<Transform>().Rotate(90.0f, 0.0f, 0.0f, Space.World);
        mainCamera.AddComponent<Camera>();
        mainCamera.GetComponent<Camera>().orthographic = true;
        mainCamera.GetComponent<Camera>().orthographicSize = 8;
    }

    void Update()
    {
        mainCamera.GetComponent<Transform>().Rotate(rotateDeltaX, rotateDeltaY, rotateDeltaZ, Space.World);
    }
}
