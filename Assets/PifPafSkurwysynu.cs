using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PifPafSkurwysynu : MonoBehaviour
{
    public GameObject prefabToShoot; // Prefab of the object to shoot
    public Transform launchPoint; // Point from where the object is launched
    public float shootingForce = 10f; // Initial force applied to the object
    public float shootingInterval = 0.5f; // Interval between shots

    private bool isShooting = false;
    private float timeSinceLastShot = 0f;

    void Update()
    {
        // Check if the left mouse button is held down
        if (Input.GetMouseButton(0))
        {
            isShooting = true;
        }
        else
        {
            isShooting = false;
            timeSinceLastShot = 0f; // Reset the timer when the button is released
        }

        // Shoot if the player is holding down the left mouse button and enough time has passed
        if (isShooting)
        {
            timeSinceLastShot += Time.deltaTime;
            if (timeSinceLastShot >= shootingInterval)
            {
                ShootObject();
                timeSinceLastShot = 0f; // Reset the timer after shooting
            }
        }
        else
        {
            // Allow shooting if the left mouse button is clicked and not held down
            if (Input.GetMouseButtonDown(0))
            {
                ShootObject();
            }
        }
    }

    void ShootObject()
    {
        // Instantiate the prefab at the launch point
        GameObject newObject = Instantiate(prefabToShoot, launchPoint.position, Quaternion.identity);

        // Get the rigidbody component of the new object
        Rigidbody rb = newObject.GetComponent<Rigidbody>();

        // Check if the rigidbody component exists
        if (rb != null)
        {
            // Calculate the forward direction of the launch point
            Vector3 shootingDirection = launchPoint.forward;

            // Apply force to shoot the object in the forward direction
            rb.AddForce(shootingDirection * shootingForce, ForceMode.Impulse);
        }
        else
        {
            Debug.LogWarning("Rigidbody component not found on the prefab!");
        }
    }
}