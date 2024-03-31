using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartTheFuckingGameNow : MonoBehaviour
{

    public GameObject assPlug; // can be plugged somewhere else aswell

    public void ImHavingAnAneurism() {
        SceneManager.LoadScene(2);
    }
}
