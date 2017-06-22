// Step3.cs
// Written by - Y. Yeung (y-squared.net)
// June-2017


using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Step3 : UIStepBase
{
    public GameObject takeSurveyButton;
    public GameObject continueButton;

    void Start()
    {
        base.BaseStart();
    }
	public void ToSurvey()
    {
        // Open survey link
        Application.OpenURL(participantsManager.GetRegisteredParticipantURL());

        // Activate continue
        takeSurveyButton.SetActive(false);
        continueButton.SetActive(true);
    }
}
