using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerprefsrTest : MonoBehaviour
{
    void Start()
    {
        Debug.Log("\tIsHaskey");
        Debug.Log(PlayerPrefs.HasKey("Name"));
        Debug.Log(PlayerPrefs.HasKey("Count"));
        Debug.Log(PlayerPrefs.HasKey("Cost"));

        Debug.Log("\tIsHaskey");
        Debug.Log(PlayerPrefs.GetString("Name"));
        Debug.Log(PlayerPrefs.GetInt("Count"));
        Debug.Log(PlayerPrefs.GetFloat("Cost"));

        Debug.Log("\tSet the Variable");
        PlayerPrefs.SetString("Name", "Cat Figures");
        PlayerPrefs.SetInt("Count", 3);
        PlayerPrefs.SetFloat("Cost", 4.50f);
    }

    public void DeleteAllPlayerPrefs()
    {
        Debug.Log("Deleting. . .");
        PlayerPrefs.DeleteAll();
    }
}
