// SurveyWorld.cs
// Written by - Y. Yeung (y-squared.net)
// June-2017


using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{

	public void ChangeScene(string sceneName)
    {
        //Application.LoadLevel(sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
