using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour
{

	public void ChangeScene(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
