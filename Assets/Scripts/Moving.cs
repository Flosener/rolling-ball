using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{
    // Define variables.
    private Rigidbody _rigidbody;
    public float speed;
    public float jump;

    private void Start()
    {
        // Initial ball position.
        transform.position = new Vector3(0,0.5f,0);
        // Get the component from our GameObject.
        _rigidbody = GetComponent<Rigidbody>();
        // If there is no such component return an error message.
        if (_rigidbody == null)
        {
            Debug.LogError("No Rigidbody found.");
        }
    }

    // Fixed Update is called every fixed timestep (default: 0.02s).
    // Use fixed update since we want to apply physics (constant force).
    void FixedUpdate()
    {
        // Attach force physics (with given speed) to the ball.
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        _rigidbody.AddForce(new Vector3(x * speed, 0, z * speed), ForceMode.Acceleration);
    }

    private void Update()
    {
        // Ball jumps when hitting the space bar.
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(new Vector3(0,1,0) * jump, ForceMode.Impulse);
        }
    }
}
