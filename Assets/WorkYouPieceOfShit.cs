using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkYouPieceOfShit : MonoBehaviour
{
    public GameObject fatass; // 
    public AnimationClip nutCrackerButWhichOne; // my cat is meowing every 10 goddamn seconds

    private Animation iDontFuckingKnow;
    private bool playerInRange;

    private void Start()
    {
// sdaudsaugfdsagdsfsghudafjgfdshjgfdsjhgdsfhjgdsf
        iDontFuckingKnow = fatass.GetComponent<Animation>();
        if (iDontFuckingKnow == null)
        {
            Debug.LogError("Target object does not have an Animation component!");
        }


        if (iDontFuckingKnow != null && nutCrackerButWhichOne != null)
        {
            iDontFuckingKnow.AddClip(nutCrackerButWhichOne, nutCrackerButWhichOne.name);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            PlayAnimation();
        }
    }

    private void OnTriggerExit(Collider other)
    {




































        if (other.CompareTag("Player"))
        {
            playerInRange = false;
        }
    }

    private void PlayAnimation()
    {









        if (iDontFuckingKnow != null && nutCrackerButWhichOne != null)
        {
            iDontFuckingKnow.Play(nutCrackerButWhichOne.name);
        }
    }
}
