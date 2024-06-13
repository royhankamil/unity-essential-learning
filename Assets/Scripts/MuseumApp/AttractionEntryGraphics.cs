using System.Collections;
using System.Collections.Generic;
using MuseumApp;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class AttractionEntryGraphics : MonoBehaviour
{
    public Image thumbnail;

    public TMP_Text attractionTitle;
    public TMP_Text attractionLocation;

    private AttractionConfig attractionConfig;

    public void OnClick()
    {
        SceneManager.LoadScene("AttractionScreen(Aseli)", LoadSceneMode.Single);
    }

    public void Setup(AttractionConfig config)
    {
        attractionConfig = config;
        
        attractionTitle.text = attractionConfig.title;
        attractionLocation.text = attractionConfig.location;

        // setup thumbnail image
        // setup the ratings
    }
}
