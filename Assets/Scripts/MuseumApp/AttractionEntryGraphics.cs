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
    public List<Image> stars;
    public Color activateColor = new Color(1f, 0.75f, 0f);
    public Color inactivateColor = new Color(0.78f, 0.78f, 0.78f);
    public AttractionScreenParameters screenParametersPrefab;

    private AttractionConfig attractionConfig;

    public void OnClick()
    {
        var parametersObject = Instantiate(screenParametersPrefab);
        parametersObject.attractionConfig = attractionConfig;
        SceneManager.LoadScene("AttractionScreen(Aseli)", LoadSceneMode.Single);
    }

    public void Setup(AttractionConfig config)
    {
        attractionConfig = config;
        
        attractionTitle.text = attractionConfig.title;
        attractionLocation.text = attractionConfig.location;

        SetupThumbnail();
        SetupStars(4);
    }

    private void SetupThumbnail()
    {
        thumbnail.sprite = attractionConfig.image;
        RectTransform rectTransform = thumbnail.GetComponent<RectTransform>();
        rectTransform.anchoredPosition3D = attractionConfig.thumbnailPosition;
        rectTransform.sizeDelta = attractionConfig.thumbnailSize;
    }

    private void SetupStars(int activateStars)
    {
        for (int i = 0; i < stars.Count; i++)
        {
            stars[i].color = i < activateStars ? activateColor : inactivateColor; 
        }
    }
}
