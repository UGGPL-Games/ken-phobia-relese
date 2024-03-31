using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextBotDeing : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("kill"))
        {
            Destroy(gameObject);
        }
    }
}