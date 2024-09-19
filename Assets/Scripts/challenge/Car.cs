using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Car : Vehicle
{
    public float rotationSpeed = 100.0f;  // Kecepatan rotasi player
    private void Stir ()
    {
        if (Input.GetKey(KeyCode.L))
        {
            transform.Rotate(Vector3.forward, -rotationSpeed * Time.deltaTime);
        }

        // Rotasi ke kiri ketika tombol "K" ditekan
        if (Input.GetKey(KeyCode.K))
        {
            transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
        }
    }

    protected override void Update ()
    {
        base.Update();
        Stir();
    }
}
