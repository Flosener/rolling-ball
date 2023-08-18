using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Component should be attached to the main camera in the scene
public class CameraMovement : MonoBehaviour
{
    public Transform ballTransform;
    private Transform _cameraTransform;
    private Vector3 _initialOffset;

    private void Start()
    {
        _cameraTransform = GetComponent<Transform>();
        _initialOffset = ballTransform.position - _cameraTransform.position;
    }
    
    // Updates camera position every frame keeping the same initial distance from the ball
    private void Update()
    {
        _cameraTransform.position = ballTransform.position - _initialOffset;
    }
}
