using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Step1: UIStepBase
{
    //[HideinInspector]
    public GameObject submitButton;

    private int input;
    private int sizeOfID; 

    public int GetInputID()
    {
        return input;
    }

    public void OnInputChanged(string newInput)
    {
        // Update the new input
        input = int.Parse(newInput);

        // Check if the characterLimit for the inputField is met
        InputField inputField = this.GetComponent<InputField>();
        sizeOfID = 5;           // [Yvy] - TODO: Un-hard code this 

        if (newInput.Length == sizeOfID)
        {
            submitButton.GetComponent<Button>().interactable = true;
        }
        else
        {
            submitButton.GetComponent<Button>().interactable = false;
        }
    }

    public void OnSubmit()
    {
        // Check if the user is allowed through

            // The user is allowed to go through
            ProceedToNextStep();
            return;

        // The user isn't allowed to go through
        //SendErrorStep();
    }
}
