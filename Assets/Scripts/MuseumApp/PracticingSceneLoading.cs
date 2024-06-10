using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PracticingSceneLoading : MonoBehaviour
{
    public void LoadWorkingUI(LoadSceneMode mode)
    {
        SceneManager.LoadScene("Working with UI", mode);
    }
    public void LoadTest(LoadSceneMode mode)
    {
        SceneManager.LoadScene("test__", mode);
    }
}
