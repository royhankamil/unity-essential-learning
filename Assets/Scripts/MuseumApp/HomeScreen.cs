using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MuseumApp
{
    public class HomeScreen : MonoBehaviour
    {
        public RectTransform attractionEntriesParent;
        public AttractionEntryGraphics attractionPrefabs;
        public AttractionConfig attraction;
        // public AttractionEntryGraphics attractionPrefabs2;

        void Awake()
        {
            var newAttraction = Instantiate(attractionPrefabs, attractionEntriesParent);
            // var newAttraction2 = Instantiate(attractionPrefabs2, attractionEntriesParent);

            // setup attraction prefabs
            newAttraction.Setup(attraction);
        }


        public void Signup()
        {
            SceneManager.LoadScene("SignupPopup", LoadSceneMode.Additive);
        }
    }

}