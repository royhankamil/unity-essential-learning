using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PracticingSceneLoading : MonoBehaviour
{
    public void LoadWorkingUI(string mode)
    {
        switch (mode)
        {
            case "single":
                SceneManager.LoadScene("Working with UI", LoadSceneMode.Single);
                break;
            case "additive":
                SceneManager.LoadScene("Working with UI", LoadSceneMode.Additive);
                break;
            default:
                break;
        }
    }
    public void LoadTest(string mode)
    {
        switch (mode)
        {
            case "single":
                SceneManager.LoadScene("test__", LoadSceneMode.Single);
                break;
            case "additive":
                SceneManager.LoadScene("test__", LoadSceneMode.Additive);
                break;
            default:
                break;
        }
    }

    public void Close()
    {
        SceneManager.UnloadScene("SignupPopup");
    }
}
