using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MuseumApp
{
    public class HomeScreen : MonoBehaviour
    {
        public GameObject loginButton;
        public TMP_Text username;

        public RectTransform attractionEntriesParent;
        public AttractionEntryGraphics attractionPrefabs;
        public List<AttractionConfig> attractions;
        // public AttractionEntryGraphics attractionPrefabs2;

        void Awake()
        {
            // var newAttraction = Instantiate(attractionPrefabs, attractionEntriesParent);
            // var newAttraction2 = Instantiate(attractionPrefabs2, attractionEntriesParent);

            // setup attraction prefabs
            // newAttraction.Setup(attraction);
            foreach (var attraction in attractions)
            {
                var newAttraction = Instantiate(attractionPrefabs, attractionEntriesParent);

                newAttraction.Setup(attraction);
            }

            SetupUsername();
        }


        public void Signup()
        {
            SceneManager.LoadScene("SignupPopup", LoadSceneMode.Additive);
        }

        public void SetupUsername()
        {
           if (!PlayerPrefs.HasKey(PlayerData.playerDataSaveKey))
           {
                loginButton.SetActive(true);
                username.gameObject.SetActive(false);
                return;
           } 

           var playerData = JsonUtility.FromJson<PlayerData>(PlayerPrefs.GetString(PlayerData.playerDataSaveKey));

            loginButton.SetActive(false);
            username.gameObject.SetActive(true);

            username.text = playerData.username;
        }
    }

}