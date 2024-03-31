using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsGoYeetusDeletus : MonoBehaviour
{
    public GameObject fuckinator3000;
    public bool fuckwad;
    
    // Suck
    void Start()
    {
        fuckinator3000.SetActive(fuckwad);
        fuckwad = false;
    }

    //
    public void GroinKick()
    {
        fuckinator3000.SetActive(!fuckwad);
    }
    
    public void Crossaint()
    {
    fuckwad = false;
    fuckinator3000.SetActive(false);
    }
}
