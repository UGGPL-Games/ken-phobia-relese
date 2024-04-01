using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FuckingPhysicsModQuestionInGameDevTalk : MonoBehaviour
{
    public TMP_InputField inputFuckingField;
    public GameObject xj;
    public AudioSource sexSource;
    public AudioClip aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa;
    public float terroristsWin = 3f; // Time to aaaaaaaaaaaaaaaaaaaaaaaaaaaaa

    private void Start()
    {
        // dsacribe tdsadsadsadsadsadsadsdsadao dsasaddsadsa dsadsaonSdsdsadsadsa
        xj.SetActive(false);
        inputFuckingField.onSubmit.AddListener(OnInputSubmit);
    }

    private void OnInputSubmit(string inputText)
    {
        //
        if (inputText.ToLower().Contains("physics mod") || inputText.ToLower().Contains("pysik mod") || inputText.ToLower().Contains("fysik mod") || inputText.ToLower().Contains("physic mod") || inputText.ToLower().Contains("physik mod") || inputText.ToLower().Contains("pysics mod") || inputText.ToLower().Contains("mod physics") || inputText.ToLower().Contains("mod physic") || inputText.ToLower().Contains("mods physic") || inputText.ToLower().Contains("fysk mod"))
        {
            // I
            Debug.Log("yolo");
            xj.SetActive(true);
            PlayAudio();
            Invoke("RageQuit", terroristsWin);
        }
    }
    
    public void ITookADump() {
            xj.SetActive(true);
            PlayAudio();
            Invoke("RageQuit", terroristsWin);
    }

    // get the fuck out
    private void RageQuit()
    {
        Application.Quit();
    }

    // please shut the fuck up
    private void PlayAudio()
    {
        if (sexSource != null && aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa != null)
        {
            sexSource.PlayOneShot(aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa); // this is most likely CJ getting mad because you didn't brain enough
        }
    }
}