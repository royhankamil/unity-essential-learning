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

        void Awake()
        {
            var newAttraction = Instantiate(attractionPrefabs, attractionEntriesParent);
        }


        public void Signup()
        {
            SceneManager.LoadScene("SignupPopup", LoadSceneMode.Additive);
        }
    }

}