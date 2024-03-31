using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBeamsOCS : MonoBehaviour { public GameObject gameDevTalk; void Start() { Debug.Log("its actually ocd"); gameDevTalk.SetActive(false);} public void OCD() { gameDevTalk.SetActive(true); } }