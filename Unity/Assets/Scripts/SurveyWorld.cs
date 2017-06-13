using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// Written by - Yvy (y-squared.net)

// [SETUP IN UNITY]


// [TO MODIFY CURRENT STEPS]


// [TO ADD MORE STEPS]


// [TO REMOVE STEPS]

public class SurveyWorld : MonoBehaviour
{
    // Set up in editor
    public GameObject[] steps;
    public GameObject stepHeaderObj;
    public GameObject stepExplanationObj;
    public GameObject errorMessageObj;
    public string[] errorTexts;
    public string[] stepExplanations;

    // Mod-able
    

    // Do not mod - Modifying variables below will alter the way ToNextStep() operates
    private int newID = 0;
    private int currentStep = 0;


    //-----------------------------------------------------------------------------------------------------------------
    // MONOBEHAVIOUR
    void Start()
    {
        // 

        // Make sure everything is set up properly
        for (int i = 0; i < steps.Length; ++i)
        {
            if (steps[i] == null)
                Debug.LogError("Step " + i + ": is null");
        }
        for (int i = 0; i < errorTexts.Length; ++i)
        {
            if (errorTexts[i] == "")
                Debug.LogError("errorText for " + errorTexts[i] + " is blank");
        }

        UpdateGUIText();
    }


    //-----------------------------------------------------------------------------------------------------------------
    // OK TO MOD
    private bool InputIsValid()
    {
        print("Checking Input");

        return true;
    }

    private bool StartSurveyAudio()
    {
        print("Starting Video Survey");
        return true;
    }

    private bool SendToSurvey()
    {
        print("Sending user to survey link");
        return true;
    }

    private bool SendToGames()
    {
        print("Sending user to the game");
        return true;
    }


    //-----------------------------------------------------------------------------------------------------------------
    // ADD NEW STEPS


    //-----------------------------------------------------------------------------------------------------------------
    // DO NOT MOD
    public void ToNextStep()
    {
        if (currentStep == 0)
        {
            if (!InputIsValid())
            {
                SendErrorMessage();
                return;
            }
        }
        else if (currentStep == 1)
        {
            if (!StartSurveyAudio())
            {
                SendErrorMessage();
                return;
            }
        }

        // Error check
        if (currentStep >= (steps.Length - 1))
        {
            print("Ended");
            return;
        }

        // Clear error message if active
        errorMessageObj.SetActive(false);

        // Next UI
        steps[currentStep].SetActive(false);
        currentStep++;
        steps[currentStep].SetActive(true);

        UpdateGUIText();

    }

    // Activates the error message and displays the current step error messages listed in string[] errorTexts
    public void SendErrorMessage()
    {
        errorMessageObj.GetComponent<Text>().text = errorTexts[currentStep];
        errorMessageObj.SetActive(true);
    }

    // Activates the error message and displays a specific message passed through the errorMsg param
    public void SendErrorMessage(string errorMsg)
    {
        errorMessageObj.GetComponent<Text>().text = errorMsg;
        errorMessageObj.SetActive(true);
    }

    // Changes to the next of step for the header and explanations
    private void UpdateGUIText()
    {
        stepHeaderObj.GetComponent<Text>().text = "Step " + (currentStep + 1) + ":";
        stepExplanationObj.GetComponent<Text>().text = stepExplanations[currentStep];
    }
}
