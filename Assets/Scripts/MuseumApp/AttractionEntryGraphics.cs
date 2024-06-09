using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class AttractionEntryGraphics : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("AttractionScreen(Aseli)", LoadSceneMode.Single);
    }
}
