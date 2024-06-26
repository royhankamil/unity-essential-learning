using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MuseumApp
{
    public class AttractionScreen : MonoBehaviour
    {
        public Image cover;

        public TMP_Text attractionTitle;
        public TMP_Text attractionLocation;
        public TMP_Text attractionAuthor;
        public TMP_Text attractionDescription;

        public List<Image> stars;
        public Color activateColor = new Color(1f, 0.75f, 0f);
        public Color inactivateColor = new Color(0.78f, 0.78f, 0.78f);

        private AttractionScreenParameters attractionScreenParameters;
        
        public void OnClickBack()
        {
            Destroy(attractionScreenParameters.gameObject);
            SceneManager.LoadScene("HomeScreen", LoadSceneMode.Single);
        }

        private void Start() 
        {
            attractionScreenParameters = GameObject.FindAnyObjectByType<AttractionScreenParameters>();
            var attractionConfig = attractionScreenParameters.attractionConfig;

            attractionTitle.text = attractionConfig.title;
            attractionLocation.text = attractionConfig.location;
            attractionAuthor.text = attractionConfig.author;
            attractionDescription.text = attractionConfig.description;


            // Method call to load cover image to attraction
            // Method call for setting up the stars
        }

        // Method to load cover image to attraction

        // Method for setting up the stars
        
    }
}