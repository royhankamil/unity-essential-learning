using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physisc : MonoBehaviour
{
    public GameObject spheree;

    void Start()
    {
        GameObject sphere1 =  Instantiate(spheree );
        sphere1.transform.position = new Vector3( 0f, 100f, 0f);
        sphere1.transform.rotation = Quaternion.Euler( 0f,45f,0);

        GameObject sphere2 =  Instantiate(spheree, transform);
        sphere2.transform.position = new Vector3( 0f, -10f, 0f);
        sphere2.transform.localRotation = Quaternion.Euler( 0f,45f,0);
        

        Instantiate(spheree, transform );
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Instantiate(spheree).transform.position = new Vector3(Random.Range(100, 100), Random.Range(100, 100), Random.Range(100, 100));
        }
    
    }
    
}
