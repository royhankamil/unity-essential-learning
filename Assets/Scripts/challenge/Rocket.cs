using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : Vehicle
{
    protected override void Update()
    {
        base.Update();
        if (Input.GetKey(KeyCode.L))
        {
            transform.position += Vector3.right * 0.3f;
        }

        // Rotasi ke kiri ketika tombol "K" ditekan
        if (Input.GetKey(KeyCode.K))
        {
            transform.position += Vector3.left * 0.3f;
        }
    }
}
