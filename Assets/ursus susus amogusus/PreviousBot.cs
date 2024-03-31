using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PreviousBot : MonoBehaviour
{
    public float moveSpeed = 5f; // Increased move speed
    public float wanderRadius = 10f;
    public float changeDirectionInterval = 2f;
    public float chaseRadius = 5f;
    public float jumpForce = 5f;
    public Vector3 rotationAxis = Vector3.up;

    private Transform player;
    private Vector3 randomDestination;
    private float nextDirectionChangeTime;
    private Rigidbody rb;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        randomDestination = GetRandomDestination();
        nextDirectionChangeTime = Time.time + changeDirectionInterval;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        Vector3 directionToPlayer = player.position - transform.position;
        directionToPlayer.y = 0f;
        Quaternion targetRotation = Quaternion.LookRotation(directionToPlayer, rotationAxis);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, Time.deltaTime * 180f);

        if (distanceToPlayer <= chaseRadius)
        {
            randomDestination = player.position;
        }
        else
        {
            if (Time.time >= nextDirectionChangeTime || Vector3.Distance(transform.position, randomDestination) < 0.1f)
            {
                randomDestination = GetRandomDestination();
                nextDirectionChangeTime = Time.time + changeDirectionInterval;
            }
        }

        Vector3 moveDirection = (randomDestination - transform.position).normalized;
        Vector3 targetPosition = transform.position + moveDirection * moveSpeed * Time.deltaTime;

        // Move towards the target position directly
        rb.MovePosition(targetPosition);

        if (IsGrounded() && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    Vector3 GetRandomDestination()
    {
        Vector3 randomDirection = Random.insideUnitSphere * wanderRadius;
        randomDirection += transform.position;
        randomDirection.y = transform.position.y;
        return randomDirection;
    }

    bool IsGrounded()
    {
        RaycastHit hit;
        float distanceToGround = 0.1f;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, distanceToGround))
        {
            return true;
        }
        return false;
    }
}