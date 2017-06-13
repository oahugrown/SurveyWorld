using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIStepBase : MonoBehaviour
{

    SurveyWorld scriptObj;

    void Start()
    {
        scriptObj = GameObject.Find("Script").GetComponent<SurveyWorld>();

    }

    protected void ProceedToNextStep()
    {
        scriptObj.ToNextStep();
    }

    protected void SendErrorMessage(string messageToSend)
    {
        scriptObj.SendErrorMessage(messageToSend);
    }

    protected void SendErrorStep()
    {
        scriptObj.SendErrorMessage();
    }

}
