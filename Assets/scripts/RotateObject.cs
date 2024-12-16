using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    // Speed of rotation and vertical movement, adjustable from the inspector
    public float rotationSpeed = 20f;
    public float floatSpeed = 1f;      // Speed of the up and down movement
    public float floatHeight = 0.5f;   // Maximum height difference for the up and down movement

    // Initial position to oscillate from
    private float startY;

    void Start()
    {
        // Store the starting y position of the object
        startY = transform.position.y;
    }

    void Update()
    {
        // Rotate the object around the Y axis
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);

        // Calculate the new Y position for the floating effect
        float newY = startY + Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        // Apply the new position while keeping X and Z the same
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
