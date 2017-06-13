﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Step2 : UIStepBase
{
    public GameObject audioObject;
    public GameObject continueButton;

    public void OnPlay()
    {
        // Reset the coroutine and play the audio
        StopAllCoroutines();
        audioObject.GetComponent<AudioSource>().Play();
        StartCoroutine(StartTimer());
    }

    IEnumerator StartTimer()
    {
        AudioSource audioSource = audioObject.GetComponent<AudioSource>(); 

        yield return new WaitForSeconds(audioSource.clip.length);
        // The user has finished listening to all the audio
        continueButton.GetComponent<Button>().interactable = true;
    }
}
