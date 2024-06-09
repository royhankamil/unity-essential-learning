using UnityEngine;
using UnityEngine.SceneManagement;

namespace MuseumApp
{
    public class AttractionScreen : MonoBehaviour
    {
        public void OnClickBack()
        {
            // body if click back
           SceneManager.LoadScene("HomeScreen", LoadSceneMode.Single);
        }
    }
}