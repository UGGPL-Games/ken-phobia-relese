using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextBot : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float rotationSpeed;
    
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = (player.transform.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);

            // Move the NextBot
            rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Reverse direction when colliding with an obstacle
            speed = -speed;
        }
    }
}