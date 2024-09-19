using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInterface : MonoBehaviour, ITest
{
    public string NameTest {get; set;}
    public void Log(int score)
    {
        Debug.Log($"score: {score} | {NameTest}");
    }

    private void Awake() 
    {
        Log(20);
    }
}
