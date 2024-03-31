using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public float exitTime = 5f; // Time in seconds before application exits

    private float timer = 0f;
    private bool shouldExit = false;

    void Update()
    {
        // Increment the timer
        timer += Time.deltaTime;

        // Check if the timer has exceeded the exit time
        if (timer >= exitTime && !shouldExit)
        {
            shouldExit = true;
            ExitApplication();
        }
    }

    void ExitApplication()
    {
        Debug.Log("Exiting application...");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}