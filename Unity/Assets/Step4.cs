// Step4.cs
// Written by - Y. Yeung (y-squared.net)
// June-2017


using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Step4 : UIStepBase
{
    public string[] textToDisplay = new string[2];
    public GameObject textToDisplay_object;
    public ParticleSystem starsEffects;

    public override void StepStart()
    {
        base.BaseStart();
        DetermineText();
    }

    void DetermineText()
    {
        if (participantsManager == null || textToDisplay_object == null)
        {
            Debug.LogError("NULL Object found in Step4.DetermineText()");
            SendErrorStep();
            return;
        }

        // true == ME Games; false = Poptropica
        bool result = participantsManager.GetRegisteredParticipantResult();

        if (result)
            textToDisplay_object.GetComponent<Text>().text = textToDisplay[0];
        
        else
            textToDisplay_object.GetComponent<Text>().text = textToDisplay[1];

        if (starsEffects == null)
            return;
        starsEffects.Play();
    }
}
