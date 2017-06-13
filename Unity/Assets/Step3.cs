using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Step3 : UIStepBase
{
    public GameObject takeSurveyButton;
    public GameObject continueButton;

	public void ToSurvey()
    {
        // Open survey link
        Application.OpenURL("http://y-squared.net");

        // Activate continue
        takeSurveyButton.SetActive(false);
        continueButton.SetActive(true);
    }

}
