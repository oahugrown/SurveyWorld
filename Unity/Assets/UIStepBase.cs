// UIStepBase.cs
// Written by - Y. Yeung (y-squared.net)
// June-2017


using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIStepBase : MonoBehaviour
{

    SurveyWorld scriptObj;
    protected ParticipantsManager participantsManager;

    protected void BaseStart()
    {
        scriptObj = GameObject.Find("Script").GetComponent<SurveyWorld>();
        participantsManager = GameObject.FindWithTag("ParticipantsManager").GetComponent<ParticipantsManager>();
        print(participantsManager);
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

    public virtual void StepStart()
    {

    }
}
