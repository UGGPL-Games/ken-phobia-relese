using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedofilGoniDzieci : MonoBehaviour
{
    public GameObject chasingObject;
    public string playerTag = "Player"; // Tag of the player object
    public float speed = 5f; // configurable speed
    public Vector3 chaseDirection = Vector3.left; // configurable chase direction

    private bool isChasing = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag))
        {
            isChasing = true;
            Debug.Log("Player entered trigger zone. Chasing started.");
        }
    }

    private void Update()
    {
        if (isChasing)
        {
            MoveChasingObject();
        }
    }

    private void MoveChasingObject()
    {
        chasingObject.transform.Translate(chaseDirection * speed * Time.deltaTime);
        Debug.Log("Chasing object is moving.");
    }
}