using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookCamera : MonoBehaviour
{
    public Camera MainCamera;

    private void Awake()
    {
        MainCamera = Camera.main;
    }

    private void Update()
    {
        transform.rotation = MainCamera.transform.rotation;
    }
}
