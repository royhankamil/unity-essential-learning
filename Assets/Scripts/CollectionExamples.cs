using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionExamples : MonoBehaviour
{
    public string[] characterClasses = new string[4] { "Warrior", "Mage", "Rogue", "Ranger"};
    public List<string> characterNames = new List<string>();
    public Dictionary<string, string> characterGear = new Dictionary<string, string>();
    private void Awake() 
    {
        characterNames.Add("William");
        characterNames.Add("Jennifer");
        characterNames.Remove("William");

        characterGear.Add("head", "Steel Helmet");
        characterGear.Add("chest", "Plate Chest Armor");
        characterGear.Add("feet", "Leather Boots");

        // Debug.Log(characterNames[0] + characterClasses[1] + characterGear["chest"]);
        // Debug.Log(characterClasses[1]);
        // Debug.Log(characterGear["chest"]);
        Debug.Log($"Character Info: \n {characterNames[0]}, \n {characterClasses[1]}, \n {characterGear["chest"]}");


    }
}
