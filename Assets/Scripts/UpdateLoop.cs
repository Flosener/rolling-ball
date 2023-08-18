using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateLoop : MonoBehaviour
{
    private void OnEnable()
    {
        Debug.Log("Enabled");
    }

    private void Awake()
    {
        Debug.Log("Awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("__________________");
        Debug.Log("Updated with time:" + Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Debug.Log("Fix updated with time:" + Time.fixedTime);
    }

    private void LateUpdate()
    {
        Debug.Log("Late updated with time:" + Time.deltaTime + Time.fixedTime);
        Debug.Log("__________________");
    }

    private void OnDisable()
    {
        Debug.Log("Disabled");
    }

    private void OnDestroy()
    {
        Debug.Log("Destroyed");
    }
}
