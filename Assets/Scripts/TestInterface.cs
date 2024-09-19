using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInterface : MonoBehaviour, ITest<int>
{
    public string NameTest {get; set;}
    public void Log(int score)
    {
        Debug.Log($"score: {score} | {NameTest}");
    }

    private void Awake() 
    {
        NameTest = "agsu";
        Log(20);
    }
}
