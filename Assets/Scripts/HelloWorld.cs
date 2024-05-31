using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string awakeMessage = "hello awake 3.0";
    public Vector2 aVector2 = new Vector2(20, 3);
    public Vector3 aVector3;
    public double aDouble;
    public float aFloat = 3.4f;
    public char aChar = 'c';
    public bool aBool;

    private void Awake() 
    {
        // awakeMessage = "hello awake 2.0";
        // Debug.Log(awakeMessage);    
        Debug.Log(aVector2);    
        Debug.Log(aVector3);    
    }

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("start");    
        Debug.Log(aDouble);    
        Debug.Log(aFloat);    
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("update");    
        Debug.Log(aChar);    
        Debug.Log(aBool);    
    }
}
