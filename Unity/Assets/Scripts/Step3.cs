// Step3.cs
// Written by - Y. Yeung (y-squared.net)
// June-2017


using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Runtime.InteropServices;

public class Step3 : UIStepBase
{
    [DllImport("__Internal")]
    private static extern void openWindow(string url);

    public GameObject takeSurveyButton;
    public GameObject continueButton;

    void Start()
    {
        base.BaseStart();
    }
	public void ToSurvey()
    {
        // Open survey link
#if UNITY_EDITOR
        Application.OpenURL(participantsManager.GetRegisteredParticipantURL());
#endif



#if UNITY_WEBGL && !UNITY_EDITOR
        // ------------------------------------------------------------------------------------------------------------
        openWindow(participantsManager.GetRegisteredParticipantURL());
        // ------------------------------------------------------------------------------------------------------------
#endif

#if UNITY_IOS
        Application.OpenURL(participantsManager.GetRegisteredParticipantURL());
#endif

        // Activate continue
        takeSurveyButton.SetActive(false);
        continueButton.SetActive(true);
    }
}
