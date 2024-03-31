using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI
;

public class Santa : MonoBehaviour
{
    public Slider slider;
    public float decreaseInterval = 1f;
    private float timer;

    void Start()
    {
        timer = decreaseInterval;
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0f)
        {
            timer = decreaseInterval;
            DecreaseSliderValue();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            IncreaseSliderValue();
        }
    }

    void DecreaseSliderValue()
    {
        if (slider != null && slider.value > 0f) // Check if slider value is greater than 0
        {
            slider.value -= 0.01f;
        }
    }

    void IncreaseSliderValue()
    {
        if (slider != null)
        {
            slider.value += 0.1f;
            if (slider.value > 1f)
            {
                slider.value = 500f;
            }
        }
    }
}