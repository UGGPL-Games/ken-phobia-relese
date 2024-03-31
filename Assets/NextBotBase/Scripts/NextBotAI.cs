using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NextBotAI : MonoBehaviour
{
    [Header("Next Bot AI Settings")]
    [Tooltip("NavMeshAgent component of the next bot")]
    public NavMeshAgent nextBotAgent; // Our next bot

    [Header("Player Settings")]
    [Tooltip("Tag of the player object")]
    public string playerTag = "Player"; // Tag of the player object

    private Transform playerTransform; // Reference to the player's transform

    private void Start()
    {
        // Find the player object based on the tag
        GameObject playerObject = GameObject.FindGameObjectWithTag(playerTag);
        if (playerObject != null)
        {
            playerTransform = playerObject.transform;
        }
        else
        {
            Debug.LogError("Player object with tag " + playerTag + " not found!");
        }
    }

    private void Update()
    {
        if (playerTransform != null)
        {
            nextBotAgent.SetDestination(playerTransform.position);
        }
    }
    // bro dis really the simplest AI ever honestly if you can call it an AI but it does the job why
    // am I typing this? Nobody is gonna read this.
    // He He Funny monkey
}
